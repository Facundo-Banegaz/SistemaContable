using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Unidad
    {
        //inicializa
        private CD_Conexion Conexion;
        private Unidad unidad;
        private List<Unidad> listaUnidad;
        // Método para listar todos los edificios
        public List<Unidad> ListaUnidades()
        {
            // Instancia de conexión y lista
            Conexion = new CD_Conexion();
            listaUnidad = new List<Unidad>();

            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_Unidades"); // Procedimiento almacenado para listar unidades

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    // Creación de objeto Unidad
                    unidad = new Unidad();

                    // Asignación de propiedades principales de la Unidad
                    unidad.Id = (int)Conexion.Lector["Id"];
                    unidad.NumeroUnidad = (string)Conexion.Lector["Numero_Unidad"];
                    unidad.Piso = (string)Conexion.Lector["Piso"];
                    unidad.Porcentaje = Convert.ToSingle(Conexion.Lector["Porcentaje"]);
                    unidad.GastosMensuales = Convert.ToSingle(Conexion.Lector["Gastos_Mensuales"]);

                    // Asignación del Propietario
                    unidad.Propietario = new Propietario();
                    unidad.Propietario.Id = (int)Conexion.Lector["PropietarioId"];
                    unidad.Propietario.ApyNom = (string)Conexion.Lector["ApyNom"];
                    unidad.Propietario.NumeroDocumento = (string)Conexion.Lector["Numero_Documento"];

                    // Asignación del Consorcio
                    unidad.Consorcio = new Consorcio();
                    unidad.Consorcio.Id = (int)Conexion.Lector["ConsorcioId"];
                    unidad.Consorcio.Nombre = (string)Conexion.Lector["Nombre"];
                    unidad.Consorcio.Direccion = (string)Conexion.Lector["Direccion"];
                    unidad.Consorcio.Cuit = (string)Conexion.Lector["Cuit"];


                    // Añadir el objeto Unidad a la lista
                    listaUnidad.Add(unidad);
                }

                return listaUnidad;
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

        // Método para insertar una nueva Unidad
        public void InsertarUnidad(Unidad unidad)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("Sp_Insertar_Unidad");


                Conexion.SetearParametro("@Numero_Unidad", unidad.NumeroUnidad);
                Conexion.SetearParametro("@Piso", unidad.Piso);
                Conexion.SetearParametro("@Porcentaje", unidad.Porcentaje);
                Conexion.SetearParametro("@Gastos_Mensuales", unidad.GastosMensuales);
                Conexion.SetearParametro("@Id_Propietario", unidad.Propietario.Id);
                Conexion.SetearParametro("@Id_Consorcio", unidad.Consorcio.Id);

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

        // Método para editar una Unidad existente
        public void EditarUnidad(Unidad unidad)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_Unidad");

                Conexion.SetearParametro("@Id", unidad.Id);
                Conexion.SetearParametro("@Numero_Unidad", unidad.NumeroUnidad);
                Conexion.SetearParametro("@Piso", unidad.Piso);
                Conexion.SetearParametro("@Porcentaje", unidad.Porcentaje);
                Conexion.SetearParametro("@Gastos_Mensuales", unidad.GastosMensuales);
                Conexion.SetearParametro("@Id_Propietario", unidad.Propietario.Id);
                Conexion.SetearParametro("@Id_Consorcio", unidad.Consorcio.Id);

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

        // Método para eliminar una Unidad por su Id
        public void EliminarUnidad(int id)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_Unidad");

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

        public bool ValidarUnidad(int NumUnidad)
        {
            Conexion = new CD_Conexion();
            try
            {
                // Consulta para verificar si existe un unidad con el nombre dado
                Conexion.SetConsutar("SELECT COUNT(*) FROM Unidades WHERE Nombre = @Numero_Unidad");
                Conexion.SetearParametro("@NumUnidad", NumUnidad);

                Conexion.EjecutarLectura();

                // Leer el resultado del conteo
                Conexion.Lector.Read();
                int count = Convert.ToInt32(Conexion.Lector[0]);

                return count > 0; // Retorna true si el conteo es mayor a 0
            }
            catch (Exception ex)
            {
                // Agregar contexto adicional al error
                throw new Exception("Error al validar el nombre del edificio.", ex);
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }
        public List<Unidad> UnidadBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaUnidad = new List<Unidad>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_Unidades");

                Conexion.SetearParametro("@txt_buscar", buscar);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    unidad = new Unidad();

                    // Asignación de propiedades de Unidad
                    unidad.Id = Conexion.Lector["Id"] != DBNull.Value ? Convert.ToInt32(Conexion.Lector["Id"]) : 0;
                    unidad.NumeroUnidad = Conexion.Lector["Numero_Unidad"]?.ToString();
                    unidad.Piso = Conexion.Lector["Piso"]?.ToString();
                    unidad.Porcentaje = Conexion.Lector["Porcentaje"] != DBNull.Value ? Convert.ToSingle(Conexion.Lector["Porcentaje"]) : 0f;
                    unidad.GastosMensuales = Conexion.Lector["Gastos_Mensuales"] != DBNull.Value ? Convert.ToInt32(Conexion.Lector["Gastos_Mensuales"]) : 0;

                    // Asignación de Propietario
                    unidad.Propietario = new Propietario
                    {
                        Id = Conexion.Lector["Id_Propietario"] != DBNull.Value ? Convert.ToInt32(Conexion.Lector["Id_Propietario"]) : 0,
                        ApyNom = Conexion.Lector["ApyNom"]?.ToString(),
                        NumeroDocumento = Conexion.Lector["Numero_Documento"]?.ToString()
                    };

                    // Asignación de Consorcio
                    unidad.Consorcio = new Consorcio
                    {
                        Id = Conexion.Lector["Id_Consorcio"] != DBNull.Value ? Convert.ToInt32(Conexion.Lector["Id_Consorcio"]) : 0,
                        Nombre = Conexion.Lector["Nombre"]?.ToString(),
                        Direccion = Conexion.Lector["Direccion"]?.ToString(),
                        Cuit = Conexion.Lector["Cuit"]?.ToString()
                    };

                    listaUnidad.Add(unidad);
                }

                return listaUnidad;
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
