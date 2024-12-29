using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Ingreso
    {
        public int Id { get; set; }
        public float MontoPagado { get; set; }

        // Relaciones
        [DisplayName("Consorcio")]
        public Consorcio Consorcio { get; set; }

        [DisplayName("Propietario")]
        public Propietario Propietario { get; set; }


    }
}
