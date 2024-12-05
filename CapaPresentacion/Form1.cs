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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
        //    frmPrincipal frmprincipal = new frmPrincipal();
        //    frmprincipal.Show();
        //    this.Hide();

            frmMenu frmmenu=new frmMenu(); 
            frmmenu.Show();
            this.Hide();
        }

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.Font = new Font(lblSalir.Font.FontFamily, lblSalir.Font.Size + 1);
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.Font = new Font(lblSalir.Font.FontFamily, lblSalir.Font.Size - 1);
        }

        
    }
}
