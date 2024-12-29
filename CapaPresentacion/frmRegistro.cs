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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void ipbSalirRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnEgresos_Click(object sender, EventArgs e)
        {
            frmEgreso frmegreso= new frmEgreso();
            frmegreso.ShowDialog();
        }

        private void ibtnIngresos_Click(object sender, EventArgs e)
        {
            frmIngreso frmingreso= new frmIngreso();
            frmingreso.ShowDialog();
        }

        private void ibtnExpensas_Click(object sender, EventArgs e)
        {
            frmExpensa frmexpensa= new frmExpensa();
            frmexpensa.ShowDialog();
        }

        private void ibtnProp_Click(object sender, EventArgs e)
        {
            frmPropietarioRegistro frmpropregistro= new frmPropietarioRegistro();
            frmpropregistro.ShowDialog();
        }

        private void ibtnComunicados_Click(object sender, EventArgs e)
        {
            frmComunicado frmcomunicado=new frmComunicado();
            frmcomunicado.ShowDialog();
        }

        private void ibtnAgenda_Click(object sender, EventArgs e)
        {
           AgendaGeneral agendageneral=new AgendaGeneral();
            agendageneral.ShowDialog();
        }
    }
}
