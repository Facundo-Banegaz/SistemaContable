using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Propietario
    {
        public int Id { get; set; }

        [DisplayName("Apellido Nombre")]
        public string ApyNom { get; set; }



        [DisplayName("Documento")]
        public string NumeroDocumento { get; set; }


        [DisplayName("Email")]
        public string Email { get; set; }


        [DisplayName("Telefono")]
        public string Telefono { get; set; }

        //Relaciones

        public List<Unidad> Unidades { get; set; }
        public List<Ingreso> Ingresos { get; set; }

        public override string ToString()
        {
            return ApyNom;
        }

    }
}
