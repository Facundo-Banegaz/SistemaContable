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
            Application.Exit();
        }

        private void ibtnEgresos_Click(object sender, EventArgs e)
        {
            frmEgreso frmegreso= new frmEgreso();
            frmegreso.Show();
        }

        private void ibtnIngresos_Click(object sender, EventArgs e)
        {
            frmIngreso frmingreso= new frmIngreso();
            frmingreso.Show();
        }

        private void ibtnExpensas_Click(object sender, EventArgs e)
        {
            frmExpensa frmexpensa= new frmExpensa();
            frmexpensa.Show();
        }

        private void ibtnProp_Click(object sender, EventArgs e)
        {
            frmPropietarioRegistro frmpropregistro= new frmPropietarioRegistro();
            frmpropregistro.Show();
        }

        private void ibtnComunicados_Click(object sender, EventArgs e)
        {
            frmComunicado frmcomunicado=new frmComunicado();
            frmcomunicado.Show();
        }

        private void ibtnAgenda_Click(object sender, EventArgs e)
        {
           AgendaGeneral agendageneral=new AgendaGeneral();
            agendageneral.Show();
        }
    }
}
