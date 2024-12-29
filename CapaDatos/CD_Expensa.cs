using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Expensa
    {
        private CD_Conexion Conexion;
        private Expensa Expensa;
        private List<Expensa> listaExpensa;



        public List<Expensa> BuscarExpensas(int id)
        {
            Conexion = new CD_Conexion();
            listaExpensa = new List<Expensa>();

            try
            {
                // Configurar el procedimiento almacenado
                Conexion.SetConsutarProcedure("Sp_Obtener_Propietarios_Por_Consorcio");

                // Pasar el parámetro de búsqueda al procedimiento almacenado
                Conexion.SetearParametro("@Id_Consorcio", id);

                // Ejecutar la consulta
                Conexion.EjecutarLectura();

                // Leer cada fila de los resultados
                while (Conexion.Lector.Read())
                {
           
                    Expensa = new Expensa();



                    Expensa.Consorcio  = new Consorcio();

                    Expensa.Consorcio.Nombre = (string)Conexion.Lector["Consorcio"];
                    //Expensa.Consorcio.Cuit = (string)Conexion.Lector["Cuit"];
                    //Expensa.Consorcio.Direccion = (string)Conexion.Lector["Direccion"];

                    Expensa.Propietario = new Propietario();

                    Expensa.Propietario.ApyNom = (string)Conexion.Lector["Propietario"];
                    //Expensa.Propietario.NumeroDocumento = (string)Conexion.Lector["Documento"];
                    //Expensa.Propietario.Email = (string)Conexion.Lector["Email"];
                    //Expensa.Propietario.Telefono = (string)Conexion.Lector["Telefono"];

                    Expensa.Unidad = new Unidad();

                    //Expensa.Unidad.Piso = (string)Conexion.Lector["Piso"];
                    //Expensa.Unidad.NumeroUnidad = (string)Conexion.Lector["Numero_Unidad"];

                    Expensa.Unidad.Porcentaje = Convert.ToSingle(Conexion.Lector["Porcentaje_Unidad"]);
                    Expensa.Egreso = new Egreso();

                    Expensa.Egreso.Monto = Convert.ToSingle(Conexion.Lector["Monto_Egreso"]);
              
                    Expensa.Monto_Final = Convert.ToSingle(Conexion.Lector["Monto_Final"]);


                    // Añadir el consorcio a la lista
                    listaExpensa.Add(Expensa);
                }

                return listaExpensa;
            }
            catch (Exception ex)
            {
                // Capturar y agregar contexto al error
                throw new Exception("Error al buscar expensas. Detalle: " + ex.Message, ex);
            }
            finally
            {
                // Asegurar el cierre de la conexión
                Conexion.CerrarConection();
            }
        }

    }
}
