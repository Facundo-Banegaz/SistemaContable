using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Egreso
    {

        private CD_Egreso _Egreso;

        public void InsertarEgreso(Egreso Nuevo, TipoEgreso Detalle)
        {
            _Egreso = new CD_Egreso();

            _Egreso.InsertarEgreso(Nuevo, Detalle);
        }
    }
}
