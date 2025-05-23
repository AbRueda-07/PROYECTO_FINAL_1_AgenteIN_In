using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InvestigadorAI_Final.DataAccess;
using InvestigadorAI_Final.Models;

namespace InvestigadorAI_Final.Forms
{
    public partial class FormRegistrosBD : Form
    {
        private DataGridView _dataGridViewRegistros;
        private Button _btnCerrar;
        private Button _btnEliminar;

        public FormRegistrosBD()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            InicializarDataGridView();
            InicializarBotones();
            CargarRegistros();
        }

        private void ConfigurarInterfaz()
        {
            this.Text = "Registros Guardados";
            this.Size = new Size(1197,657);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InicializarDataGridView()
        {
            _dataGridViewRegistros = new DataGridView
            {
                Location = new Point(20, 100),
                Size = new Size(740, 400),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            this.Controls.Add(_dataGridViewRegistros);
        }

        private void InicializarBotones()
        {

            this.Controls.Add(_btnCerrar);

           
            this.Controls.Add(btnEliminarResultadoPorId);
        }

        private void CargarRegistros()
        {
            try
            {
                var dbManager = new DatabaseManager();
                List<Investigacion> registros = dbManager.ObtenerTodosLosResultados();

                if (registros.Count == 0)
                {
                    MessageBox.Show("No hay registros guardados.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _dataGridViewRegistros.DataSource = registros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminarResultadoPorId_Click(object sender, EventArgs e)
        {
            if (_dataGridViewRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un registro para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("¿Estás seguro de eliminar el registro seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idSeleccionado = Convert.ToInt32(_dataGridViewRegistros.SelectedRows[0].Cells["Id"].Value);
                    var dbManager = new DatabaseManager();
                    dbManager.EliminarResultadoPorId(idSeleccionado);

                    CargarRegistros(); // Refrescar DataGridView
                    MessageBox.Show("Registro eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
