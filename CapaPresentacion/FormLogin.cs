using CapaDominio;
using CapaNegocio;
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

            CN_Administrador _Administrador = new CN_Administrador();

            Administrador administrador = _Administrador.Login(txtUsuario.Text, txtContrasena.Text);

            if (administrador != null)
            {

               

                //para que me muestre un mensaje en la ventana 
                Text = $"¡Bienvenido {administrador.NombreUsuario}  {administrador.Matricula}!";

                // Usuario válido, realizar acciones correspondientes (por ejemplo, mostrar el formulario principal)
                string mensaje = $"Inicio de sesión exitoso. ¡Bienvenido al Sistema Nombre de Usuario: {administrador.NombreUsuario}  | Accediste como: {administrador.Acceso}!";
                MessageBox.Show(mensaje, "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMenu menu = new frmMenu(administrador);

                this.Hide();
                menu.Show();
            }
            else
            {
                // Usuario no válido, mostrar mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos, intentar de nuevo.", " No tiene Acceso al Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Clear();
                txtContrasena.Clear();

            }
        }

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quieres Salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

     
    }
}
