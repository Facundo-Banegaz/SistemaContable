using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Expensa
    {

        public Consorcio Consorcio { get; set; }

        public Propietario Propietario { get; set; }

        public Unidad Unidad { get; set; }

        public Egreso Egreso { get; set; }
        public float Monto_Final { get; set; }
    }
}
