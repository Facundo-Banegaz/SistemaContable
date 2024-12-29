using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Expensa
    {

        private CD_Expensa _CD_Expensa;

        // Método para listar Ingresos
        public List<Expensa> BuscarExpensas(int Id)
        {
            _CD_Expensa = new CD_Expensa();

            return _CD_Expensa.BuscarExpensas(Id);
        }
    }
}
