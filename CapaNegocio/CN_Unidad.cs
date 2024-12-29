using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Unidad
    {

        private CD_Unidad _CD_Unidad;

        // Método para listar Unidads
        public List<Unidad> ListaUnidades()
        {
            _CD_Unidad = new CD_Unidad();
            return _CD_Unidad.ListaUnidades();
        }

        // Método para insertar un nuevo Unidad
        public void InsertarUnidad(Unidad nuevoUnidad)
        {
            _CD_Unidad = new CD_Unidad();
            _CD_Unidad.InsertarUnidad(nuevoUnidad);
        }

        // Método para editar un Unidad
        public void EditarUnidad(Unidad Unidad)
        {
            _CD_Unidad = new CD_Unidad();
            _CD_Unidad.EditarUnidad(Unidad);
        }

        // Método para eliminar un Unidad
        public void EliminarUnidad(int id)
        {
            _CD_Unidad = new CD_Unidad();
            _CD_Unidad.EliminarUnidad(id);
        }

        // Método para buscar Unidads por texto
        public List<Unidad> UnidadBuscar(string buscar)
        {
            _CD_Unidad = new CD_Unidad();
            return _CD_Unidad.UnidadBuscar(buscar);
        }

        ////Método para validar si un Unidad ya existe
        public bool ValidarUnidad(int Numero_Unidad)
        {
            _CD_Unidad = new CD_Unidad();
            return _CD_Unidad.ValidarUnidad(Numero_Unidad);
        }
    }
}
