using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
   public class Arbitrajemodel
    {
        public int id { get; set; }
        public long Arbitro { get; set; }
        public int alquiler { get; set; }
        public int  tiempo { get; set; }
        public Double precio { get; set; }
}
}
