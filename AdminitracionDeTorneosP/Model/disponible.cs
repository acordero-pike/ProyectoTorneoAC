using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Model;

namespace AdminitracionDeTorneosP.Model
{
    public class disponible
    {
 public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan HInicio { get; set; }
        public TimeSpan HFin { get; set; }

    }
}
