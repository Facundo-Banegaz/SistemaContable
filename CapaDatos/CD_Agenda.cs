using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Agenda
    {

        //inicializa
        private CD_Conexion Conexion;
        private Agenda Agenda;
        private List<Agenda> listaAgenda;
        public List<Agenda> ListaAgendas()
        {
            Conexion = new CD_Conexion();
            listaAgenda = new List<Agenda>();

            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_Agenda_General");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Agenda = new Agenda
                    {
                        Id = (int)Conexion.Lector["Id"],
                        Fecha = (DateTime)Conexion.Lector["Fecha"],
                        Descripcion = (string)Conexion.Lector["Descripcion"]
                    };

                    listaAgenda.Add(Agenda);
                }

                return listaAgenda;
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

        public void InsertarAgenda(Agenda agenda)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("sp_InsertarAgenda");

                Conexion.SetearParametro("@Fecha", agenda.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Descripcion", agenda.Descripcion);
                

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


        public void EliminarAgenda(int id)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_Agenda_General");
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
    }
}
