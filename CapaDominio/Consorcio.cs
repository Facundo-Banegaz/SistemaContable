using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Consorcio
    {
        //atributos
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { set; get; }


        [DisplayName("Dirección")]
        public string Direccion { set; get; }

        [DisplayName("Cuit")]
        public string Cuit { set; get; }
        //relacion 1:n

       
        public List<Unidad> Unidades { get; set; }
        public Administrador Administrador { get; set; }
        public List<Ingreso> Ingresos { get; set; }
        public List<Egreso> Egresos { get; set; }
        public override string ToString()
        {
            return Nombre; 
        }

    }
}
