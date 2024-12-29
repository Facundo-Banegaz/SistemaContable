using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Propietario
    {
        private CD_Conexion Conexion;
        private Propietario propietario;
        private List<Propietario> listaPropietario;

        // Método para listar propietarios
        public List<Propietario> ListaPropietarios()
        {
            Conexion = new CD_Conexion();
            listaPropietario = new List<Propietario>();

            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_propietarios");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    propietario = new Propietario
                    {
                        Id = (int)Conexion.Lector["Id"],
                        ApyNom = (string)Conexion.Lector["ApyNom"],
                        NumeroDocumento = (string)Conexion.Lector["Numero_Documento"],
                        Email = (string)Conexion.Lector["Email"],
                        Telefono = (string)Conexion.Lector["Telefono"],
                    };

                    listaPropietario.Add(propietario);
                }

                return listaPropietario;
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

        // Método para insertar un propietario
        public void InsertarPropietario(Propietario nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_propietario");

                Conexion.SetearParametro("@ApyNom", nuevo.ApyNom);
                Conexion.SetearParametro("@NumeroDocumento", nuevo.NumeroDocumento);
                Conexion.SetearParametro("@Telefono", nuevo.Telefono);
                Conexion.SetearParametro("@Email", nuevo.Email);

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

        // Método para editar un propietario
        public void EditarPropietario(Propietario propietario)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_propietario");

                Conexion.SetearParametro("@Id", propietario.Id);
                Conexion.SetearParametro("@ApyNom", propietario.ApyNom);
                Conexion.SetearParametro("@NumeroDocumento", propietario.NumeroDocumento);
                Conexion.SetearParametro("@Email", propietario.Email);
                Conexion.SetearParametro("@Telefono", propietario.Telefono);

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

        // Método para eliminar un propietario
        public void EliminarPropietario(int id)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_propietario");
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

        // Método para buscar propietarios
        public List<Propietario> PropietarioBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaPropietario = new List<Propietario>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_propietarios");
                Conexion.SetearParametro("@txt_buscar", buscar);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    propietario = new Propietario
                    {
                        Id = (int)Conexion.Lector["Id"],
                        ApyNom = (string)Conexion.Lector["ApyNom"],
                        NumeroDocumento = (string)Conexion.Lector["Numero_Documento"],
                        Email = (string)Conexion.Lector["Email"],
                        Telefono = (string)Conexion.Lector["Telefono"]
                    };

                    listaPropietario.Add(propietario);
                }

                return listaPropietario;
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

        public bool ValidarPropietario(string numeroDocumento)
        {
            try
            {
                Conexion.SetConsutarProcedure("SpValidarPropietarioPorDocumento");
                Conexion.SetearParametro("@Numero_Documento", numeroDocumento);
                Conexion.EjecutarLectura();

                // Si se encuentra un propietario, se devuelve true (ya existe)
                if (Conexion.Lector.Read())
                {
                    return true;
                }

                return false; // No existe un propietario con ese documento
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el propietario por documento.", ex);
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }
        public List<Propietario> CargarCbo()
        {

            Conexion = new CD_Conexion();
            listaPropietario = new List<Propietario>();


            try
            {
                Conexion.SetConsutar("select  Id, ApyNom from Propietarios");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    propietario = new Propietario
                    {
                        Id = (int)Conexion.Lector["Id"],
                        ApyNom = (string)Conexion.Lector["ApyNom"],
                    };

                    listaPropietario.Add(propietario);

                }

                return listaPropietario;
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
