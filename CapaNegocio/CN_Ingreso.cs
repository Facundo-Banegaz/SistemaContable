using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ingreso
    {
        private CD_Ingreso _CD_Ingreso;

        // Método para listar Ingresos
        public List<Ingreso> ListaIngresos()
        {
            _CD_Ingreso = new CD_Ingreso();
            return _CD_Ingreso.ListaIngresos();
        }

        // Método para insertar un nuevo Ingreso
        public void InsertarIngreso(Ingreso nuevoIngreso)
        {
            _CD_Ingreso = new CD_Ingreso();
            _CD_Ingreso.InsertarIngreso(nuevoIngreso);
        }

        // Método para editar un Ingreso
        public void EditarIngreso(Ingreso Ingreso)
        {
            _CD_Ingreso = new CD_Ingreso();
            _CD_Ingreso.EditarIngreso(Ingreso);
        }

        // Método para eliminar un Ingreso
        public void EliminarIngreso(int id)
        {
            _CD_Ingreso = new CD_Ingreso();
            _CD_Ingreso.EliminarIngreso(id);
        }

        // Método para buscar Ingresos por texto
        public List<Ingreso> BuscarIngreso(string texto)
        {
            _CD_Ingreso = new CD_Ingreso();
            return _CD_Ingreso.IngresoBuscar(texto);
        }

        // Método para validar si un Ingreso ya existe
        //public bool ValidarIngreso(string nombre)
        //{
        //    _CD_Ingreso = new CD_Ingreso();
        //    return _CD_Ingreso.ValidarIngreso(nombre);
        //}






    }
}
