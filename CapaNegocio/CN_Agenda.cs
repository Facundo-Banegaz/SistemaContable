using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Agenda
    {

        CD_Agenda _Agenda  = new CD_Agenda();


        public void InsertarAgenda(Agenda Nuevo)
        {

            _Agenda = new CD_Agenda();


            _Agenda.InsertarAgenda(Nuevo);

        }

        public List<Agenda> ListaAgenda()
        {
            _Agenda = new CD_Agenda();

            return _Agenda.ListaAgendas();
        }


        public void EliminarAgenda(int Id_Agenda)
        {

            _Agenda = new CD_Agenda();


            _Agenda.EliminarAgenda(Id_Agenda);
        }


    }
}
