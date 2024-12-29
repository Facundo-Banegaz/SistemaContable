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
    public partial class frmAgregarEditarAdmin : Form
    {

        private Administrador _Administrador = null;
        public frmAgregarEditarAdmin()
        {
            InitializeComponent();
            Text = "Cargar Admin";
        }
        public frmAgregarEditarAdmin(Administrador administrador)
        {
            InitializeComponent();
            Text = "Editar Admin";
            this._Administrador = administrador;
        }



        private void frmAgregarEditarAdmin_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            CargarCboAcceso();
        }
        private void CargarCboAcceso()
        {

            // Añade "Seleccionar sexo" como un elemento en el ComboBox
            cbo_acceso.Items.Add("SELECCIONAR ACCESO");

            // Añade los otros elementos (masculino, femenino, otro)
            cbo_acceso.Items.Add("ADMINISTRADOR");
            cbo_acceso.Items.Add("OTRO");
            //cbo_acceso.Items.Add("");

            // Establece "Seleccionar sexo" como el elemento predeterminado
            cbo_acceso.SelectedIndex = 0;

            // Deshabilita la selección del elemento "Seleccionar sexo"
            cbo_acceso.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void MostrarDatos()
        {

            CN_Consorcio _Consorcio = new CN_Consorcio();

            try
            {






                if (_Administrador != null)
                {


                    txt_id.Text = _Administrador.Id.ToString();
                    txtMatriculaAdmin.Text = _Administrador.Matricula;
                    txtTelefonoAdmin.Text = _Administrador.Telefono;
                    txtAdminNombre.Text = _Administrador.ApyNom;
                    cbo_acceso.SelectedValue = _Administrador.Acceso;
                    txtDniAdmin.Text = _Administrador.Dni;
                    txtNombreUsuario.Text = _Administrador.NombreUsuario; 
                    txt_clave.Text = _Administrador.Clave;



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void GuardarAdmin()
        {
            CN_Administrador _CN_Administrador = new CN_Administrador();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Administrador == null)

                        _Administrador = new Administrador();


                    _Administrador.Matricula = txtMatriculaAdmin.Text;
                    _Administrador.ApyNom = txtAdminNombre.Text;
                    _Administrador.NombreUsuario = txtNombreUsuario.Text;
                    _Administrador.Clave = txt_clave.Text;
                    _Administrador.Dni = txtDniAdmin.Text;
                    _Administrador.Telefono = txtTelefonoAdmin.Text;

                    _Administrador.Acceso = cbo_acceso.Text.ToString().Trim().ToUpper();











                    if (_Administrador.Id != 0)
                    {

                        _CN_Administrador.EditarAdministrador(_Administrador);
                        MessageBox.Show("El Admin Fue Modificado Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Administrador.InsertarAdministrador(_Administrador);
                        MessageBox.Show("El Admin Fue Agregado Exitosamente!!", "Agregado");
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
                MessageBox.Show("Se produjo un error al guardar la Unidad. Por favor, inténtelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Registra el error en algún lugar (por ejemplo, un archivo de registro)
                Console.WriteLine("Error al guardar cliente: " + ex.Message);
            }


        }


        private bool ValidarVacio()
        {
            bool error = true;


            if (cbo_acceso.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAdminNombre.Text == string.Empty)
            {
                errorIcono.SetError(txtAdminNombre, "El campo es obligatorio");
                error = false;
            }
            if (txtDniAdmin.Text == string.Empty)
            {
                errorIcono.SetError(txtDniAdmin, "El campo es obligatorio");
                error = false;
            }
            if (txtMatriculaAdmin.Text == string.Empty)
            {
                errorIcono.SetError(txtMatriculaAdmin, "El campo es obligatorio");
                error = false;
            }

            if (txtNombreUsuario.Text == string.Empty)
            {
                errorIcono.SetError(txtNombreUsuario, "El campo es obligatorio");
                error = false;
            }
            if (txtTelefonoAdmin.Text == string.Empty)
            {
                errorIcono.SetError(txtTelefonoAdmin, "El campo es obligatorio");
                error = false;
            }

            if (txt_clave.Text == string.Empty)
            {
                errorIcono.SetError(txt_clave, "El campo es obligatorio");
                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarAdmin();
        }
    }
}
