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
    public partial class FrmAgregarEditarConsorcio : Form
    {

        private Consorcio _Consorcio = null;
        public FrmAgregarEditarConsorcio()
        {
            InitializeComponent();
            Text = "Cargar Consorcio";
        }
        public FrmAgregarEditarConsorcio(Consorcio consorcio)
        {
            InitializeComponent();
            Text = "Editar Consorcio";
            this._Consorcio = consorcio;
        }
        private void MostrarDatos()
        {

            CN_Administrador _Administrador = new CN_Administrador();

            try
            {
               

                cboAdmin.DataSource = _Administrador.CargarCbo();
                cboAdmin.ValueMember = "Id";
                cboAdmin.DisplayMember = "ApyNom";

                if (_Consorcio != null)
                {


                    txt_id_consorcio.Text = _Consorcio.Id.ToString();
                    txtNombreConsorcio.Text = _Consorcio.Nombre;
                    txtDireccionConsorcio.Text = _Consorcio.Direccion;
                    txtCuitConsorcio.Text = _Consorcio.Cuit;

                    cboAdmin.SelectedValue = _Consorcio.Administrador.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregarEditarConsorcio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GuardarConsorcio()
        {
            CN_Consorcio _CN_Consorcio = new CN_Consorcio();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Consorcio == null)

                        _Consorcio = new Consorcio();



                    _Consorcio.Nombre = txtNombreConsorcio.Text.Trim().ToUpper();
                    _Consorcio.Direccion = txtDireccionConsorcio.Text;
                    _Consorcio.Cuit = txtCuitConsorcio.Text;
                    _Consorcio.Administrador = (Administrador)cboAdmin.SelectedItem;


                    if (_Consorcio.Id != 0)
                    {

                        _CN_Consorcio.EditarConsorcio(_Consorcio);
                        MessageBox.Show("El Consorcio Fue Modificado Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Consorcio.InsertarConsorcio(_Consorcio);
                        MessageBox.Show("El Consorcio Fue Agregado Exitosamente!!", "Agregado");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                // Maneja la excepción mostrando un mensaje al usuario y registrándola
                MessageBox.Show("Se produjo un error al guardar el Consorcio. Por favor, inténtelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Registra el error en algún lugar (por ejemplo, un archivo de registro)
                Console.WriteLine("Error al guardar cliente: " + ex.Message);
            }


        }


        private bool ValidarVacio()
        {
            bool error = true;



            if (txtNombreConsorcio.Text == string.Empty)
            {
                errorIcono.SetError(txtNombreConsorcio, "El campo es obligatorio, ingrese el Nombre");
                error = false;
            }
            if (txtCuitConsorcio.Text == string.Empty)
            {
                errorIcono.SetError(txtCuitConsorcio, "El campo es obligatorio, ingrese el Numero de Cuit");
                error = false;
            }
            if (txtDireccionConsorcio.Text == string.Empty)
            {
                errorIcono.SetError(txtDireccionConsorcio, "El campo es obligatorio, ingrese la Direccion");
                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarConsorcio();
        }
    }
}
