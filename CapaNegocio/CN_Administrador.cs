using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Administrador
    {
        private CD_Administrador CD_Administrador;

        ////Metodo para Listar los Productos em la DataWirdView
        public List<Administrador> ListaAdministrador()
        {
            CD_Administrador = new CD_Administrador();

            return CD_Administrador.ListarAdministrador();
        }


        public List<Administrador> CargarCbo()
        {
            CD_Administrador = new CD_Administrador();

            return CD_Administrador.CargarCbo();
        }
        ////Metodo para el login
        public Administrador Login(string Nombre_Administrador, string Clave)
        {
            CD_Administrador = new CD_Administrador();
            return CD_Administrador.Login(Nombre_Administrador, Clave);
        }
        ////Metodo para cargar un producto en la Base de Datos
        public void InsertarAdministrador(Administrador Nuevo)
        {
            CD_Administrador = new CD_Administrador();

            CD_Administrador.InsertarAdministrador(Nuevo);

        }
        //public bool ValidarAdministrador(string Dni)
        //{
        //    CD_Administrador = new CD_Administrador();

        //    return CD_Administrador.ValidarAdministrador(Dni);
        //}
        ////Metodo para Editar un producto en la Base de Datos
        public void EditarAdministrador(Administrador Administrador)
        {
            CD_Administrador = new CD_Administrador();

            CD_Administrador.EditarAdministrador(Administrador);
        }

        ////Metodo para Eliminar un producto en la Base de Datos
        public void EliminarAdministrador(int Id_Administrador)
        {
            CD_Administrador = new CD_Administrador();

            CD_Administrador.EliminarTrabajdor(Id_Administrador);
        }



        public List<Administrador> AdministradorBuscarNombre(string buscar)
        {
            CD_Administrador = new CD_Administrador();

            return CD_Administrador.AdministradorBuscarNombre(buscar);
        }


    }
}
