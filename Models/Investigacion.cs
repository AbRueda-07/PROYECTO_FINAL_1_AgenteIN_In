using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvestigadorAI_Final.Models
{
    public class Investigacion
    {
    public int Id { get; set; }
    public string Prompt { get; set; } = string.Empty;
    public string Resultado { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }
    }
}

