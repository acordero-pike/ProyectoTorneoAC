using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class Alquilermodel
    {
        public int ID { get; set; }
        public long DPI  { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        
        public DateTime Fecha_Alquiler { get; set; }
        public DateTime hora_inicio { get; set; }
    public DateTime  hora_final { get; set; }
        public Double Precio_por_hora { get; set; }
        public int ID_Cancha { get; set; }

        public Double Sub_Total_Cancha { get; set; }
        public Double Sub_Total_Arbitraje { get; set; }
        public Double Total_Alquiler { get; set; }


    }
}
