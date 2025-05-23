using InvestigadorAI_Final.Documents;
using InvestigadorAI_Final.Utils;
using InvestigadorAI_Final.DataAccess;
using InvestigadorAI_Final.Services;
using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.PowerPoint;
using System;
using WordApplication = Microsoft.Office.Interop.Word.Application;
using WordDocument = Microsoft.Office.Interop.Word.Document;
using Paragraph = Microsoft.Office.Interop.Word.Paragraph;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace InvestigadorAI_Final
{
    public partial class Form1 : Form
    {
        private static readonly string RutaCarpetaWordPPT =@"C:\PROYECTOS - PROGRAMACIÓN C#\PROYECTO_FINAL_1\InvestigadorAI_Final\InvestigadorAI_Final\Resultados Word_PPT";

        public Form1()
        {
            InitializeComponent();
            AsegurarCarpeta();
        }

        private void btnGuardarEnBD_Click(object sender, EventArgs e)
        {
            string prompt = txtPromptPersonalizado.Text;
            string resultado = rtbResultado.Text;

            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("No hay resultados para guardar.");
                return;
            }

            try
            {
                var dbManager = new DatabaseManager();
                dbManager.GuardarResultado(prompt, resultado);
                MessageBox.Show("Datos guardados correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos:\n" + ex.Message);
            }
        }

        private void btnGenerarPrompt_Click(object sender, EventArgs e)
        {
            {
                string tema = txtTemaInvestigacion.Text.Trim();
                if (string.IsNullOrEmpty(tema))
                {
                    MessageBox.Show("Ingrese un tema primero.");
                    return;
                }

                txtPromptPersonalizado.Text = $"Investiga sobre '{tema}' y entrega un resumen detallado con datos relevantes, estadísticas y conclusiones.";
            }
        }


        private void btnGenerarWord_Click_1(object sender, EventArgs e)
        {
            string resultado = rtbResultado.Text.Trim();
            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("No hay resultados para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AsegurarCarpeta();

                string nombreArchivo = $"Informe_{DateTime.Now:yyyyMMdd_HHmmss}.docx";
                string rutaCompleta = Path.Combine(RutaCarpetaWordPPT, nombreArchivo);

                var wordGen = new WordGenerator();
                wordGen.GenerarDocumento(resultado, rutaCompleta);

                MessageBox.Show($"Documento Word creado en:\n{rutaCompleta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el documento:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarPowerPoint_Click_1(object sender, EventArgs e)
        {
            string resultado = rtbResultado.Text;
            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("No hay resultados para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AsegurarCarpeta();

                string nombreArchivo = $"Presentación_{DateTime.Now:yyyyMMdd_HHmmss}.pptx";
                string rutaCompleta = Path.Combine(RutaCarpetaWordPPT, nombreArchivo);

                if (File.Exists(rutaCompleta)) File.Delete(rutaCompleta);

                var pptGen = new PowerPointGenerator();
                pptGen.GenerarPresentacion(resultado, rutaCompleta);

                MessageBox.Show($"Presentación guardada en:\n{rutaCompleta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PowerPoint:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                AsegurarCarpeta();
                System.Diagnostics.Process.Start("explorer.exe", RutaCarpetaWordPPT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la carpeta:\n" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void rtbResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void pbLoading_Click(object sender, EventArgs e)
        {

        }

        private async void btnRealizarInvestigacion_Click(object sender, EventArgs e)
        {
            string tema = txtTemaInvestigacion.Text.Trim();

            if (string.IsNullOrEmpty(tema))
            {
                MessageBox.Show("Por favor ingrese un tema de investigación.");
                return;
            }

            string prompt = txtPromptPersonalizado.Text.Trim();
            if (string.IsNullOrEmpty(prompt))
            {
                txtPromptPersonalizado.Text = $"Investiga sobre '{tema}' y entrega un análisis detallado.";
                prompt = txtPromptPersonalizado.Text;
            }

            lblEstado.Text = "Buscando información...";
            pbLoading.Visible = true;
            System.Windows.Forms.Application.DoEvents();

            var aiHelper = new OpenAIHelper();
            try
            {
                string resultado = await aiHelper.InvestigarAsync(prompt);
                rtbResultado.Text = resultado;
                lblEstado.Text = "Listo. Confirme antes de generar documentos.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener resultados:\n" + ex.Message);
                lblEstado.Text = "Error";
            }
            finally
            {
                pbLoading.Visible = false;
            }
        }

        private void btnGuardarEnBD_Click_1(object sender, EventArgs e)
        {
            string prompt = txtPromptPersonalizado.Text;
            string resultado = rtbResultado.Text;

            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("No hay resultados para guardar.");
                return;
            }

            try
            {
                var dbManager = new DatabaseManager();
                dbManager.GuardarResultado(prompt, resultado);
                MessageBox.Show("Datos guardados correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos:\n" + ex.Message);
            }
        }

        private void AsegurarCarpeta()
        {
            if (!Directory.Exists(RutaCarpetaWordPPT))
            {
                try
                {
                    Directory.CreateDirectory(RutaCarpetaWordPPT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear la carpeta:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

