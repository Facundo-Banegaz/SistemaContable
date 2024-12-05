using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //agregue libreria de fuentes

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();


            // Crear un arreglo de botones
            Button[] buttons = { ibtnRegistro, ibtnConsorcios, ibtnPropietarios, ibtnAdmin, ibtnConfig, ibtnGuiaUsuario };

            // Asignar el mismo evento MouseEnter y MouseLeave a todos los botones
            foreach (var button in buttons)
            {
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;
            }
        }

        // Cambiar el color de la fuente cuando el mouse entra en el botón
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;  // Obtener el botón que disparó el evento
            if (button != null)
            {
                button.ForeColor = Color.FromArgb(106, 102, 157);  // Cambiar el color de la fuente a rojo
            }
        }

        // Restaurar el color de la fuente cuando el mouse sale del botón
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;  // Obtener el botón que disparó el evento
            if (button != null)
            {
                button.ForeColor = Color.Silver;  // Restaurar el color de la fuente a negro
            }
        }

        private void ibtnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide(); //mantenerlo oculto y NO cerrado p/volver a él
        }

        private void ipbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ipbSalir_MouseHover(object sender, EventArgs e)
        {
            ipbSalir.ForeColor = Color.FromArgb(106, 102, 157);
        }

        private void ipbSalir_MouseLeave(object sender, EventArgs e)
        {
            ipbSalir.ForeColor = Color.Silver;
        }

        private void ibtnConsorcios_Click(object sender, EventArgs e)
        {
            frmConsorcio frmconsorcio = new frmConsorcio();
            frmconsorcio.Show();
            this.Hide();
        }

        private void ibtnPropietarios_Click(object sender, EventArgs e)
        {
            frmPropietario frmpropietario=new frmPropietario();
            frmpropietario.Show();
            this.Hide();
        }

        private void ibtnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin= new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void ibtnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmconfig=new frmConfig();
            frmconfig.Show();
            this.Hide();
        }
    }
}
