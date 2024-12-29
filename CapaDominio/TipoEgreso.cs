using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class TipoEgreso
    {
        public int Id { get; set; }

        [DisplayName("Pago al portero")]
        public float PagoPortero { get; set; }

        [DisplayName("Cargas sociales")]
        public float AportesF931 { get; set; }

        [DisplayName("Sueldos")]
        public float Suterh { get; set; }

        //[DisplayName("Horas extra")]
        public float Fateryh { get; set; }

        //[DisplayName("Día del padre")]
        public float Searcharh { get; set; }

        [DisplayName("Deudas")]
        public float Edet { get; set; }

        [DisplayName("SAT")]
        public float Sat { get; set; }

        [DisplayName("Honorarios del contador")]
        public float HonorariosContador { get; set; }

        [DisplayName("Honorarios del administrador")]
        public float HonorariosAdministrador { get; set; }

        [DisplayName("Salud pública")]
        public float DGRT { get; set; }

        [DisplayName("Seguro accidental")]
        public float Seguro { get; set; }

        public float Gastos_Bancarios { get; set; }

        [DisplayName("Fumigación")]
        public float Fumigacion { get; set; }

        [DisplayName("Remitos")]
        public float Remitos { get; set; }

        [DisplayName("Productos de limpieza")]
        public float Prod_Limpieza { get; set; }

        [DisplayName("Gastos varios")]
        public float GastosVarios { get; set; }
        
        
        // Relaciones
       
        public Egreso Egreso { get; set; }
    }
}
