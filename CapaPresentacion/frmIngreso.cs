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
    public partial class frmIngreso : Form
    {

        private List<Ingreso> listaIngresos;
        public frmIngreso()
        {
            InitializeComponent();
            Text = "Gestion Ingreso";

        }




        private void ipbExitIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            MostrarDatos();
            ArregloDataGridView(dgvMontoPagado);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Ingreso  _Ingreso  = new CN_Ingreso();


            listaIngresos = _Ingreso.ListaIngresos();

            dgvMontoPagado.DataSource = listaIngresos;

        }

        private void MostrarDatos()
        {

            CN_Propietario _Propietario = new CN_Propietario();
            CN_Consorcio _Consorcio = new CN_Consorcio();



            try
            {

                cboConsorcio.DataSource = _Consorcio.CargarCbo();
                cboConsorcio.ValueMember = "Id";
                cboConsorcio.DisplayMember = "Nombre";

                cboPropietario.DataSource = _Propietario.CargarCbo();
                cboPropietario.ValueMember = "Id";
                cboPropietario.DisplayMember = "ApyNom";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ArregloDataGridView(DataGridView dgv_propietario)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            dgv_propietario.Columns["Id"].Width = 100;
            dgv_propietario.Columns["MontoPagado"].Width = 350;
            dgv_propietario.Columns["Consorcio"].Width = 550;
            dgv_propietario.Columns["Propietario"].Width = 350;

            dgv_propietario.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["MontoPagado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Consorcio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Propietario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            _Metodos.AlternarColor(dgv_propietario);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            CargarGrilla();
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            CN_Ingreso _CN_Ingreso = new CN_Ingreso();

            try
            {
                // Validación de campos vacíos
                if (ValidarVacio())
                {
                    errorIcono.Clear();


                
                    Ingreso _Ingreso = new Ingreso();

                    _Ingreso.MontoPagado = float.Parse(txtMonto.Text);
                    _Ingreso.Consorcio = (Consorcio)cboConsorcio.SelectedItem;
                    _Ingreso.Propietario = (Propietario)cboPropietario.SelectedItem;


                    // Llamar al método de negocio para insertar
                    _CN_Ingreso.InsertarIngreso(_Ingreso);
                    txtMonto.Clear();
                    CargarGrilla();
                    // Mostrar mensaje de éxito
                    MessageBox.Show("El ingreso fue agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Se produjo un error al guardar el ingreso. Por favor, inténtelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al guardar ingreso: " + ex.Message);
            }

        }
        private bool ValidarVacio()
        {
            bool error = true;


            if (txtMonto.Text == string.Empty)
            {
                errorIcono.SetError(txtMonto, "El campo es obligatorio, ingrese el Monto");
                error = false;
            }
   
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
