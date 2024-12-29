using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Ingreso
    {

        //inicializa
        private CD_Conexion Conexion;
        private Ingreso Ingreso;
        private List<Ingreso> listaIngreso;

      

        // Método para listar todos los edificios
        public List<Ingreso> ListaIngresos()
        {
            // Instancia de conexión y lista
            Conexion = new CD_Conexion();
            listaIngreso = new List<Ingreso>();

            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_Ingresos"); // Procedimiento almacenado para listar Ingresoes

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    // Creación de objeto Consorcio
                    Ingreso = new Ingreso();


                    Ingreso.Id = (int)Conexion.Lector["Id"];
                    Ingreso.MontoPagado = Convert.ToSingle(Conexion.Lector["Monto_Pagado"]);


                    Ingreso.Propietario = new Propietario();

                    Ingreso.Propietario.Id = (int)Conexion.Lector["Id"];
                    Ingreso.Propietario.ApyNom = (string)Conexion.Lector["ApyNom"];
                    Ingreso.Propietario.NumeroDocumento = (string)Conexion.Lector["Numero_Documento"];

                    Ingreso.Consorcio = new Consorcio();

                    Ingreso.Consorcio.Id =  (int)Conexion.Lector["Id"];
                    Ingreso.Consorcio.Nombre = (string)Conexion.Lector["Nombre"];
                    Ingreso.Consorcio.Direccion = (string)Conexion.Lector["Direccion"];
                    Ingreso.Consorcio.Cuit = (string)Conexion.Lector["Cuit"];






                    // Añadir el objeto Ingreso a la lista
                    listaIngreso.Add(Ingreso);
                }

                return listaIngreso;
            }
            catch (Exception ex)
            {
                throw ex; // Manejo de excepciones
            }
            finally
            {
                Conexion.CerrarConection(); // Cerrar conexión
            }
        }

        // Método para insertar una nueva Ingreso
        public void InsertarIngreso(Ingreso Ingreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_Ingreso");


                Conexion.SetearParametro("@Monto_Pagado", Ingreso.MontoPagado);
                Conexion.SetearParametro("@Id_Consorcio", Ingreso.Consorcio.Id);
                Conexion.SetearParametro("@Id_Propietario", Ingreso.Propietario.Id);

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

        // Método para editar una Ingreso existente
        public void EditarIngreso(Ingreso Ingreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_Ingreso");

                Conexion.SetearParametro("@Id", Ingreso.Id);
                Conexion.SetearParametro("@Monto_Pagado", Ingreso.MontoPagado);
                Conexion.SetearParametro("@Id_Propietario", Ingreso.Propietario.Id);
                Conexion.SetearParametro("@Id_Consorcio", Ingreso.Consorcio.Id);

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

        // Método para eliminar una Ingreso por su Id
        public void EliminarIngreso(int id)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_Ingreso");

                Conexion.SetearParametro("@Id", id);

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

        ////public bool ValidarIngreso(string nombre)
        ////{
        ////    Conexion = new CD_Conexion();
        ////    try
        ////    {
        ////        // Consulta para verificar si existe un Ingreso con el nombre dado
        ////        Conexion.SetConsutar("SELECT COUNT(*) FROM Ingresoes WHERE Nombre = @Numero_Ingreso");
        ////        Conexion.SetearParametro("@nombre", nombre);

        ////        Conexion.EjecutarLectura();

        ////        // Leer el resultado del conteo
        ////        Conexion.Lector.Read();
        ////        int count = Convert.ToInt32(Conexion.Lector[0]);

        ////        return count > 0; // Retorna true si el conteo es mayor a 0
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        // Agregar contexto adicional al error
        ////        throw new Exception("Error al validar el nombre del edificio.", ex);
        ////    }
        ////    finally
        ////    {
        ////        Conexion.CerrarConection();
        ////    }
        ////}
        public List<Ingreso> IngresoBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaIngreso = new List<Ingreso>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_Ingreso");

                Conexion.SetearParametro("@txt_buscar", buscar);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Ingreso = new Ingreso
                    {
                        Id = (int)Conexion.Lector["Id"],
                        MontoPagado = (float)Conexion.Lector["Monto_Pagado"],


                        Propietario = new Propietario
                        {
                            Id = (int)Conexion.Lector["Id"],
                            ApyNom = (string)Conexion.Lector["ApyNom"],
                            NumeroDocumento = (string)Conexion.Lector["Numero_Documento"]
                        },

                        Consorcio = new Consorcio
                        {
                            Id = (int)Conexion.Lector["Id"],
                            Nombre = (string)Conexion.Lector["Nombre"],
                            Direccion = (string)Conexion.Lector["Direccion"],
                            Cuit = (string)Conexion.Lector["Cuit"],
                        }
                    };


                    // Agregar la Ingreso a la lista
                    listaIngreso.Add(Ingreso);
                }

                return listaIngreso;
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
