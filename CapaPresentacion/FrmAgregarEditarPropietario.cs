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
    public partial class FrmAgregarEditarPropietario : Form
    {
        private Propietario _Propietario = null;
        public FrmAgregarEditarPropietario()
        {
            InitializeComponent();
            Text = "Cargar Propietario";
        }
        public FrmAgregarEditarPropietario(Propietario propietario)
        {
            InitializeComponent();
            Text = "Editar Propietario";
            this._Propietario = propietario;
        }
        private void FrmAgregarEditarPropietario_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarDatos()
        {



            try
            {


                if (_Propietario != null)
                {


                    txt_id_propietario.Text = _Propietario.Id.ToString();
                    txt_Propietario.Text = _Propietario.ApyNom;
                    txtTel.Text = _Propietario.Telefono;
                    txt_Dni.Text = _Propietario.NumeroDocumento;
                    txtEmail.Text = _Propietario.Email;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void GuardarPropietario()
        {
            CN_Propietario _CN_Propietario = new CN_Propietario();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Propietario == null)

                        _Propietario = new Propietario();



                    _Propietario.ApyNom = txt_Propietario.Text.Trim().ToUpper();
                    _Propietario.NumeroDocumento = txt_Dni.Text;
                    _Propietario.Email = txtEmail.Text;
                    _Propietario.Telefono = txtTel.Text;


                    if (_Propietario.Id != 0)
                    {

                        _CN_Propietario.EditarPropietario(_Propietario);
                        MessageBox.Show("El Propietario Fue Modificado Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Propietario.InsertarPropietario(_Propietario);
                        MessageBox.Show("El Propietario Fue Agregado Exitosamente!!", "Agregado");
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
                MessageBox.Show("Se produjo un error al guardar el Propietario. Por favor, inténtelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Registra el error en algún lugar (por ejemplo, un archivo de registro)
                Console.WriteLine("Error al guardar cliente: " + ex.Message);
            }


        }


        private bool ValidarVacio()
        {
            bool error = true;



            if (txt_Propietario.Text == string.Empty)
            {
                errorIcono.SetError(txt_Propietario, "El campo es obligatorio, ingrese el Nombre");
                error = false;
            }
            if (txt_Dni.Text == string.Empty)
            {
                errorIcono.SetError(txt_Dni, "El campo es obligatorio, ingrese el Numero de Documento");
                error = false;
            }
            if (txtTel.Text == string.Empty)
            {
                errorIcono.SetError(txtTel, "El campo es obligatorio, ingrese el Telefono");
                error = false;
            }

            if (txtEmail.Text == string.Empty)
            {
                errorIcono.SetError(txtEmail, "El campo es obligatorio, ingrese el Email");
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
            GuardarPropietario();
        }
    }
}
