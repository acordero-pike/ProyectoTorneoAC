using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class Ususario
    {
        public int id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public long DPI{ get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        
        public string Direccion { get; set; }
        
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string puesto { get; set; }
    }
}
