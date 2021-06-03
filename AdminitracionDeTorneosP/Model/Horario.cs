using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class Horario
    {
        public string Dia { get; set; }
        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
    }
}
