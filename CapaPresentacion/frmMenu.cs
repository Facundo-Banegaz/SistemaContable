using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CapaDominio;
using FontAwesome.Sharp; //agregue libreria de fuentes

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        public Administrador _Administrador;


        
        public frmMenu(Administrador administrador)
        {
            InitializeComponent();
            this._Administrador = administrador;
            Text = $"¡¡Bienvenido al Sistema  {_Administrador.ApyNom} !! Nombre de  Usuario: ''{_Administrador.NombreUsuario}'' | Acceso: ''{_Administrador.Acceso}''.";


        }
        public frmMenu()
        {
            InitializeComponent();
        }



        private void ibtnRegistro_Click(object sender, EventArgs e)
        {
        
            frmRegistro frmRegistro = new frmRegistro();

            frmRegistro.ShowDialog();
        }


  

 

        private void ibtnConsorcios_Click(object sender, EventArgs e)
        {
           frmConsorcio frmConsorcio = new frmConsorcio();
            frmConsorcio.ShowDialog();
        }

        private void ibtnPropietarios_Click(object sender, EventArgs e)
        {
            frmPropietario frmPropietario = new frmPropietario();
            frmPropietario.ShowDialog();
        }

        private void ibtnAdmin_Click(object sender, EventArgs e)
        {
           frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();
    
        }

  
        private void ibtnGuiaUsuario_Click(object sender, EventArgs e)
        {
            // Ruta del archivo PDF
            string pdfPath = @"C:\Users\baneg\Downloads\ManualUsuario.pdf"; // Cambia esto según la ubicación de tu PDF

            if (System.IO.File.Exists(pdfPath))
            {
                FrmGuia frmGuia = new FrmGuia();
                frmGuia.PdfPath = pdfPath; // Pasa la ruta del PDF al formulario FrmGuia
                frmGuia.ShowDialog(); // Abre el formulario FrmGuia
            }
            else
            {
                MessageBox.Show("El archivo PDF no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibtnUnidades_Click(object sender, EventArgs e)
        {
            frmUnidad frmUnidad = new frmUnidad();
            frmUnidad.ShowDialog();
        }


        private void ipbSalirMenu_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Quieres Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            
        }
    }
}
