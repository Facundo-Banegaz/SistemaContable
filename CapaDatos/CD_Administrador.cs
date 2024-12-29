using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Administrador
    {
        private CD_Conexion Conexion;
        private Administrador Administrador;
        private List<Administrador> listaAdministrador;

        public List<Administrador> ListarAdministrador()
        {

            Conexion = new CD_Conexion();
            listaAdministrador = new List<Administrador>();


            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_Administradores");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Administrador = new Administrador();

                    Administrador.Id = (int)Conexion.Lector["Id"];

                    Administrador.Matricula = (string)Conexion.Lector["Matricula"];
                    Administrador.Dni = (string)Conexion.Lector["Dni"];
                    Administrador.ApyNom = (string)Conexion.Lector["ApyNom"];
                    Administrador.Clave = (string)Conexion.Lector["Clave"];
                    Administrador.NombreUsuario = (string)Conexion.Lector["Nombre_Usuario"];
                    Administrador.Acceso = (string)Conexion.Lector["Acceso"];
                    Administrador.Telefono = (string)Conexion.Lector["Telefono"];
                    
                    listaAdministrador.Add(Administrador);


                }

                return listaAdministrador;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }
        //metodo insertar

        public void InsertarAdministrador(Administrador Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_Administrador");

                Conexion.SetearParametro("@Matricula", Nuevo.Matricula);
                Conexion.SetearParametro("@Telefono", Nuevo.Telefono);
                Conexion.SetearParametro("@Dni", Nuevo.Dni);
                Conexion.SetearParametro("@ApyNom", Nuevo.ApyNom);
                Conexion.SetearParametro("@Nombre_Usuario", Nuevo.NombreUsuario);
                Conexion.SetearParametro("@Clave", Nuevo.Clave);
                Conexion.SetearParametro("@Acceso", Nuevo.Acceso);




                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

        //public bool ValidarAdministrador(string Dni)
        //{
        //    Conexion = new CD_Conexion();
        //    try
        //    {
        //        Conexion.SetConsutar("SELECT COUNT(*) FROM Administrador WHERE Numero_documento =  @Dni");
        //        Conexion.SetearParametro("@Dni", Dni);

        //        Conexion.EjecutarLectura();

        //        Verificar si hay alguna fila devuelta por la consulta
        //        if (Conexion.Lector.HasRows)
        //        {
        //            Leer el valor del primer campo(que es el resultado del conteo)
        //            Conexion.Lector.Read();
        //            int count = Convert.ToInt32(Conexion.Lector[0]);
        //            return count > 0;
        //        }
        //        else
        //        {
        //            Si no hay filas, no hay resultados, por lo que el cliente no existe
        //            return false;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        Conexion.CerrarConection();
        //    }
        //}

        //metodo editar

        public void EditarAdministrador(Administrador Administrador)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_Administrador");

                Conexion.SetearParametro("@Id", Administrador.Id);

                Conexion.SetearParametro("@Matricula", Administrador.Matricula);
                Conexion.SetearParametro("@Telefono", Administrador.Telefono);
                Conexion.SetearParametro("@Dni", Administrador.Dni);
                Conexion.SetearParametro("@ApyNom", Administrador.ApyNom);
                Conexion.SetearParametro("@Nombre_Usuario", Administrador.NombreUsuario);
                Conexion.SetearParametro("@Clave", Administrador.Clave);
                Conexion.SetearParametro("@Acceso", Administrador.Acceso);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }

        //Metodo eliminar
        public void EliminarTrabajdor(int Id)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_Administrador");

                Conexion.SetearParametro("@Id", Id);


                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

        ////Metodo Buscar


        public List<Administrador> AdministradorBuscarNombre(string buscar)
        {
            Conexion = new CD_Conexion();
            listaAdministrador = new List<Administrador>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_Administradores");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Administrador = new Administrador();

                    Administrador.Id = (int)Conexion.Lector["Id"];

                    Administrador.Matricula = (string)Conexion.Lector["Matricula"];
                    Administrador.Dni = (string)Conexion.Lector["Dni"];
                    Administrador.ApyNom = (string)Conexion.Lector["ApyNom"];
                    Administrador.Clave = (string)Conexion.Lector["Clave"];
                    Administrador.NombreUsuario = (string)Conexion.Lector["Nombre_Usuario"];
                    Administrador.Acceso = (string)Conexion.Lector["Acceso"];
                    Administrador.Telefono = (string)Conexion.Lector["Telefono"];


                    listaAdministrador.Add(Administrador);
                }


                return listaAdministrador;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

        public List<Administrador> CargarCbo()
        {

            Conexion = new CD_Conexion();
            listaAdministrador = new List<Administrador>();


            try
            {
                Conexion.SetConsutar("select Id, ApyNom  from Administradores");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Administrador = new Administrador();


                    Administrador.Id = (int)Conexion.Lector["Id"];
                    Administrador.ApyNom = (string)Conexion.Lector["ApyNom"];
                    listaAdministrador.Add(Administrador);

                }

                return listaAdministrador;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }

        public Administrador Login(string Nombre_Usuario, string Clave)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("Sp_login");

                Conexion.SetearParametro("@Nombre_Usuario", Nombre_Usuario);
                Conexion.SetearParametro("@Clave", Clave);

                Conexion.EjecutarLectura();

                if (Conexion.Lector.Read())
                {
                    Administrador = new Administrador();
                    Administrador.Id = Convert.ToInt32(Conexion.Lector["Id"]);
                    Administrador.Matricula = Conexion.Lector["Matricula"].ToString();
                    Administrador.NombreUsuario = Conexion.Lector["Nombre_Usuario"].ToString();
                    Administrador.Clave = Conexion.Lector["Clave"].ToString();
                    Administrador.Acceso = Conexion.Lector["Acceso"].ToString();
                }

                return Administrador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

    }
}
