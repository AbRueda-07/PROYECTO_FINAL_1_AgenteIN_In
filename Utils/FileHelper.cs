using System.IO;
using System;

namespace InvestigadorAI_Final.Utils
{
    public static class FileHelper
    {
        public static string CrearCarpetaResultados()
        {
            string rutaCarpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Resultados Word_PPT");

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            return rutaCarpeta;
        }
    }

}