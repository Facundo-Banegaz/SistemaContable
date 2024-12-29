using CapaDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteExpensas : Form
    {

        public int Id_consorcio { get; set; }
        public FrmReporteExpensas(int Id)
        {
            InitializeComponent();

            this.Id_consorcio = Id;
        }

        private void FrmReporteExpensas_Load(object sender, EventArgs e)
        {


            this.spReporte_ExpensasTableAdapter.Fill(this.dsReportes.SpReporte_Expensas, Id_consorcio);

            this.Rpt_Expensa.RefreshReport();
        }
    }
}
