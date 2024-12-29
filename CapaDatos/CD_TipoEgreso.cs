using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TipoEgreso
    {

        private CD_Conexion Conexion;
        public void InsertarTipoEgreso(TipoEgreso Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_TipoEgreso");

                Conexion.SetearParametro("@Pago_Portero", Nuevo.PagoPortero);
                Conexion.SetearParametro("@AportesF931", Nuevo.AportesF931);
                Conexion.SetearParametro("@Suterth", Nuevo.Suterh);
                Conexion.SetearParametro("@Fateryh", Nuevo.Fateryh);
                Conexion.SetearParametro("@Searcharh", Nuevo.Searcharh);
                Conexion.SetearParametro("@Edet", Nuevo.Edet);
                Conexion.SetearParametro("@Sat", Nuevo.Sat);
                Conexion.SetearParametro("@Honorarios_Contador", Nuevo.HonorariosContador);
                Conexion.SetearParametro("@Honorarios_Administrador", Nuevo.HonorariosAdministrador);
                Conexion.SetearParametro("@DGRT", Nuevo.DGRT);
                Conexion.SetearParametro("@Seguro", Nuevo.Seguro);
                Conexion.SetearParametro("@Gastos_Bancarios", Nuevo.Gastos_Bancarios);
                Conexion.SetearParametro("@Fumigacion", Nuevo.Fumigacion);
                Conexion.SetearParametro("@Remitos", Nuevo.Remitos);
                Conexion.SetearParametro("@Prod_Limpieza", Nuevo.Prod_Limpieza);
                Conexion.SetearParametro("@Gastos_Varios", Nuevo.GastosVarios);
                Conexion.SetearParametro("@Id_Egreso", Nuevo.Egreso.Id);


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
    }
}
