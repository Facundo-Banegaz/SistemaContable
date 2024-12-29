using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Consorcio
    {
        private CD_Consorcio _CD_Consorcio;
        // Método para listar consorcios
        public List<Consorcio> ListaConsorcios()
        {
            _CD_Consorcio = new CD_Consorcio();
            return _CD_Consorcio.ListaConsorcios();
        }
  
        // Método para insertar un nuevo consorcio
        public void InsertarConsorcio(Consorcio nuevoConsorcio)
        {
            _CD_Consorcio = new CD_Consorcio();
            _CD_Consorcio.InsertarConsorcio(nuevoConsorcio);
        }

        // Método para editar un consorcio
        public void EditarConsorcio(Consorcio consorcio)
        {
            _CD_Consorcio = new CD_Consorcio();
            _CD_Consorcio.EditarConsorcio(consorcio);
        }

        // Método para eliminar un consorcio
        public void EliminarConsorcio(int id)
        {
            _CD_Consorcio = new CD_Consorcio();
            _CD_Consorcio.EliminarConsorcio(id);
        }

        // Método para buscar consorcios por texto
        public List<Consorcio> BuscarConsorcio(string texto)
        {
            _CD_Consorcio = new CD_Consorcio();
            return _CD_Consorcio.ConsorcioBuscar(texto);
        }

        public List<Consorcio> CargarCbo()
        {
            _CD_Consorcio = new CD_Consorcio();

            return _CD_Consorcio.CargarCbo();
        }


        // Método para validar si un consorcio ya existe
        public bool ValidarConsorcio(string nombre)
        {
            _CD_Consorcio = new CD_Consorcio();
            return _CD_Consorcio.ValidarConsorcio(nombre);
        }


    }
}
