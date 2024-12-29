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
    public partial class FrmGuia : Form
    {
        public FrmGuia()
        {
            InitializeComponent();
        }

        // Propiedad para recibir la ruta del PDF
        public string PdfPath { get; set; }
        private void FrmGuia_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PdfPath) && System.IO.File.Exists(PdfPath))
            {
                webBrowser1.Navigate(PdfPath); // Carga el PDF en el WebBrowser
            }
            else
            {
                MessageBox.Show("El archivo PDF no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
