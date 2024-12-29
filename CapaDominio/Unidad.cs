using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Unidad
    {
		public int Id { get; set; }


		[DisplayName("Numero De la Unidad")]
		public string NumeroUnidad { get; set; }


		[DisplayName("Numero Del Piso")]
		public string Piso { get; set; }

		[DisplayName("Numero  Del Porcetanje")]
		public float Porcentaje { get; set; }


		[DisplayName("Gastos Mensuales")]

		public float GastosMensuales { get; set; }

        [DisplayName("Propietario")]
        public Propietario Propietario { get; set; }


        [DisplayName("Edificio")]
		public Consorcio Consorcio { get; set; }

        public override string ToString()
        {
            return Porcentaje.ToString();
        }
    }

}
