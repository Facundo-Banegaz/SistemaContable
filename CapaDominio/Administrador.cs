using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Administrador
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public string ApyNom { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Acceso { get; set; }

       //Relaciones

        public List<Consorcio> consorcios { get; set; } 
        public override string ToString()
        {
            return ApyNom;
        }
    }
}
