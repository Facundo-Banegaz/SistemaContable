using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Consorcio
    {
        //inicializa
        private CD_Conexion Conexion;
        private Consorcio Consorcio;
        private List<Consorcio> listaConsorcio;


        //Método Mostrar

        public List<Consorcio> ListaConsorcios()
        {
            // Instancia
            Conexion = new CD_Conexion();
            listaConsorcio = new List<Consorcio>();

            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_consorcios"); 

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    // Creación de objeto Consorcio
                    Consorcio = new Consorcio();

                    
                    Consorcio.Id = (int)Conexion.Lector["Id"]; 
                    Consorcio.Nombre = (string)Conexion.Lector["Nombre"];
                    Consorcio.Direccion = (string)Conexion.Lector["Direccion"];
                    Consorcio.Cuit = (string)Conexion.Lector["Cuit"];

                    Consorcio.Administrador = new Administrador();

                    Consorcio.Administrador.Id = (int)Conexion.Lector["AdministradorId"];

                    Consorcio.Administrador.Matricula = (string)Conexion.Lector["Matricula"];
                    Consorcio.Administrador.Dni = (string)Conexion.Lector["Dni"];
                    Consorcio.Administrador.ApyNom = (string)Conexion.Lector["ApyNom"];
                    Consorcio.Administrador.Clave = (string)Conexion.Lector["Clave"];
                    Consorcio.Administrador.NombreUsuario = (string)Conexion.Lector["Nombre_Usuario"];
                    Consorcio.Administrador.Acceso = (string)Conexion.Lector["Acceso"];
                    Consorcio.Administrador.Telefono = (string)Conexion.Lector["Telefono"];

                    // Añadir el objeto Consorcio a la lista
                    listaConsorcio.Add(Consorcio);
                }

                return listaConsorcio;
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
        // Método Insertar

        public void InsertarConsorcio(Consorcio Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_Consorcio");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Direccion", Nuevo.Direccion);
                Conexion.SetearParametro("@Cuit", Nuevo.Cuit);
                Conexion.SetearParametro("@Id_Administrador", Nuevo.Administrador.Id);

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
        // Método Editar

        public void EditarConsorcio(Consorcio Consorcio)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_Consorcio");

                Conexion.SetearParametro("@Id", Consorcio.Id); 
                Conexion.SetearParametro("@Nombre", Consorcio.Nombre);
                Conexion.SetearParametro("@Direccion", Consorcio.Direccion);
                Conexion.SetearParametro("@Cuit", Consorcio.Cuit);
                Conexion.SetearParametro("@Id_Administrador", Consorcio.Administrador.Id);
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
        // Método Eliminar

        public void EliminarConsorcio(int Id)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_Consorcio");

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
        // Método Buscar
        public List<Consorcio> CargarCbo()
        {

            Conexion = new CD_Conexion();
            listaConsorcio = new List<Consorcio>();


            try
            {
                Conexion.SetConsutar("select Id, Nombre from Consorcios");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Consorcio = new Consorcio();


                    Consorcio.Id = (int)Conexion.Lector["Id"];
                    Consorcio.Nombre = (string)Conexion.Lector["Nombre"];
                    listaConsorcio.Add(Consorcio);

                }

                return listaConsorcio;
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
        public List<Consorcio> ConsorcioBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaConsorcio = new List<Consorcio>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_Consorcios");

                Conexion.SetearParametro("@txt_buscar", buscar);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Consorcio = new Consorcio();

                    Consorcio.Id = (int)Conexion.Lector["Id"];
                    Consorcio.Nombre = (string)Conexion.Lector["Nombre"];
                    Consorcio.Direccion = (string)Conexion.Lector["Direccion"];
                    Consorcio.Cuit = (string)Conexion.Lector["Cuit"];
                    Consorcio.Administrador = new Administrador();

                    Consorcio.Administrador.ApyNom = (string)Conexion.Lector["ApyNom"];
                    listaConsorcio.Add(Consorcio);
                }

                return listaConsorcio;
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

        public bool ValidarConsorcio(string Nombre)
        {
            Conexion = new CD_Conexion();
            try
            {
                // Consulta para verificar si existe un Consorcio con el nombre dado
                Conexion.SetConsutar("SELECT COUNT(*) FROM Consorcios WHERE Nombre = @Nombre");
                Conexion.SetearParametro("@Nombre", Nombre);

                Conexion.EjecutarLectura();

                // Verificar si hay alguna fila devuelta por la consulta
                if (Conexion.Lector.HasRows)
                {
                    // Leer el valor del primer campo (que es el resultado del conteo)
                    Conexion.Lector.Read();
                    int count = Convert.ToInt32(Conexion.Lector[0]);
                    return count > 0; // Si el conteo es mayor que 0, el Consorcio existe
                }
                else
                {
                    // Si no hay filas, no hay resultados, el Consorcio no existe
                    return false;
                }

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
