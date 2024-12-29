using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Agenda
    {


        public int Id { get; set; }




        [DisplayName("Fecha")]
        public DateTime Fecha { set; get; }



        [DisplayName("Descripcion")]
        public string Descripcion { set; get; }


    }
}
