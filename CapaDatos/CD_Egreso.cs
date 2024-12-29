using CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Egreso
    {
        private CD_Conexion Conexion;

        public void InsertarEgreso(Egreso Nuevo, TipoEgreso tipoEgreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                //Conexion.IniciarTransaccion();

                Conexion.SetConsutarProcedure("SpInsertar_Egreso");

                Conexion.SetearParametro("@Descripcion", Nuevo.Descripcion);
                Conexion.SetearParametro("@Monto", Nuevo.Monto);

                Conexion.SetearParametro("@Fecha", Nuevo.FechaPublicacion.ToString("yyyy-MM-dd hh:mm:ss"));

                Conexion.SetearParametro("@Id_Consorcio", Nuevo.Consorcio.Id);
          



                // Configurar el parámetro de salida para el ID de ingreso

                Conexion.SetearParametroSalida("@Id", SqlDbType.Int);

                Conexion.EjecutarAccion();


                // Capturar el ID del Egreso insertado
                int Id_Egreso = Conexion.ObtenerValorParametroSalida("@Id");




                CD_TipoEgreso _TipoEgreso = new CD_TipoEgreso();

                // Pasar directamente un solo detalle sin bucle
                tipoEgreso.Egreso.Id = Id_Egreso;
                _TipoEgreso.InsertarTipoEgreso(tipoEgreso);


               


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
