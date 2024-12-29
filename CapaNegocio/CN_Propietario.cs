using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Propietario
    {
        private CD_Propietario _CD_Propietario;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Propietario> ListaPropietario()
        {
            _CD_Propietario = new CD_Propietario();

            return _CD_Propietario.ListaPropietarios();
        }
        public List<Propietario> CargarCbo()
        {
            _CD_Propietario = new CD_Propietario();

            return _CD_Propietario.CargarCbo();
        }

        public bool ValidarPropietario(string Dni)
        {

            _CD_Propietario = new CD_Propietario();


            return _CD_Propietario.ValidarPropietario(Dni);
        }
        public void InsertarPropietario(Propietario Nuevo)
        {

            _CD_Propietario = new CD_Propietario();


            _CD_Propietario.InsertarPropietario(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarPropietario(Propietario cliente)
        {

            _CD_Propietario = new CD_Propietario();


            _CD_Propietario.EditarPropietario(cliente);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarPropietario(int Id_Propietario)
        {

            _CD_Propietario = new CD_Propietario();


            _CD_Propietario.EliminarPropietario(Id_Propietario);
        }


        //Metodo para Buscar un producto en la Base de Datos
        public List<Propietario> PropietarioBuscarApellido(string buscar)
        {

            _CD_Propietario = new CD_Propietario();


            return _CD_Propietario.PropietarioBuscar(buscar);
        }


    }
}
