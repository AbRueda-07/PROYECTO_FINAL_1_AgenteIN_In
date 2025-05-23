using System.IO;
using Word =Microsoft.Office.Interop.Word;

namespace InvestigadorAI_Final.Documents
{
    public class WordGenerator
    {
        public void GenerarDocumento(string contenido, string rutaArchivo)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            Word.Paragraph titulo = doc.Content.Paragraphs.Add();
            titulo.Range.Text = "Resultado de Investigación";
            titulo.Range.Font.Bold = 1;
            titulo.Range.Font.Size = 16;
            titulo.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titulo.Range.InsertParagraphAfter();

            Word.Paragraph parrafo = doc.Content.Paragraphs.Add();
            parrafo.Range.Text = contenido;
            parrafo.Range.Font.Size = 12;
            parrafo.Range.InsertParagraphAfter();

            if (File.Exists(rutaArchivo)) File.Delete(rutaArchivo);

            doc.SaveAs2(rutaArchivo);
            doc.Close(false);
            wordApp.Quit();
        }
    }
}
