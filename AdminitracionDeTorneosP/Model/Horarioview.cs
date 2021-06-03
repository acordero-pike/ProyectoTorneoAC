using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class Horarioview
    {
        public string Dia { get; set; }
        public TimeSpan Apertura { get; set; }
        public TimeSpan Cierre { get; set; }
    }
}
