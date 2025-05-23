using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System.IO;

namespace InvestigadorAI_Final.Documents
{
    public class PowerPointGenerator
    {
        // Carpeta fija donde se guardará la presentación
        private readonly string _rutaBase = @"C:\PROYECTOS - PROGRAMACIÓN C#\PROYECTO_FINAL_1\InvestigadorAI_Final\InvestigadorAI_Final";
        private readonly string _carpetaDestino;

        public PowerPointGenerator()
        {
            _carpetaDestino = Path.Combine(_rutaBase, "Resultados Word_PPT");

            if (!Directory.Exists(_carpetaDestino))
                Directory.CreateDirectory(_carpetaDestino);
        }

        public void GenerarPresentacion(string contenido, string rutaGuardado)
        {
            try
            {
                // Definir nombre del archivo con fecha
                string nombreArchivo = $"Presentación_{DateTime.Now:yyyyMMdd_HHmmss}.pptx";
                string rutaArchivo = Path.Combine(_carpetaDestino, nombreArchivo);

                // Crear aplicación PowerPoint (sin mostrarla)
                Microsoft.Office.Interop.PowerPoint.Application pptApp = new Microsoft.Office.Interop.PowerPoint.Application();
                Presentation pres = pptApp.Presentations.Add(MsoTriState.msoTrue);

                Slide slide = pres.Slides.Add(1, PpSlideLayout.ppLayoutTitle);
                slide.Shapes[1].TextFrame.TextRange.Text = "Resultado de Investigación";
                slide.Shapes[2].TextFrame.TextRange.Text = "Resumen generado automáticamente.";

                slide = pres.Slides.Add(2, PpSlideLayout.ppLayoutText);
                slide.Shapes[1].TextFrame.TextRange.Text = "Contenido";
                slide.Shapes[2].TextFrame.TextRange.Text = contenido.Substring(0, Math.Min(contenido.Length, 250)) + "...";

                pres.SaveAs(rutaArchivo, PpSaveAsFileType.ppSaveAsPresentation, MsoTriState.msoTrue);
                pres.Close();
                pptApp.Quit();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar PowerPoint: " + ex.Message);
            }
        }
    }
}