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
    public partial class FrmAgregarEditarUnidad : Form
    {


        private Unidad _Unidad = null;


        public FrmAgregarEditarUnidad()
        {
            InitializeComponent();
            Text = "Cargar Unidad";
        }
        public FrmAgregarEditarUnidad(Unidad unidad)
        {
            InitializeComponent();
            Text = "Editar Unidad";
            this._Unidad = unidad;
        }
        private void FrmAgregarEditarUnidad_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private void MostrarDatos()
        {

            CN_Consorcio _Consorcio = new CN_Consorcio();
            CN_Propietario _Propietario = new CN_Propietario();




            try
            {


                cboPropietario.DataSource = _Propietario.CargarCbo();
                cboPropietario.ValueMember = "Id";
                cboPropietario.DisplayMember = "ApyNom";


                cboConsorcio.DataSource = _Consorcio.CargarCbo();
                cboConsorcio.ValueMember = "Id";
                cboConsorcio.DisplayMember = "Nombre";




                if (_Unidad != null)
                {


                    txt_id_unidad.Text = _Unidad.Id.ToString();
                    txt_numUnidad.Text = _Unidad.NumeroUnidad;
                    txt_piso.Text = _Unidad.Piso;
                    txtPorcentaje.Text = _Unidad.Porcentaje.ToString();
                    txt_gastosmensuales.Text = _Unidad.GastosMensuales.ToString();

                    cboPropietario.SelectedValue = _Unidad.Propietario.Id;
                    cboConsorcio.SelectedValue = _Unidad.Consorcio.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GuardarUnidad()
        {
            CN_Unidad _CN_Unidad = new CN_Unidad();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Unidad == null)

                        _Unidad = new Unidad();


                    _Unidad.NumeroUnidad = txt_numUnidad.Text;
                    _Unidad.Piso = txt_piso.Text;
                    _Unidad.Porcentaje = float.Parse(txtPorcentaje.Text);
                    _Unidad.GastosMensuales = float.Parse(txt_gastosmensuales.Text);
                   
                    

                    _Unidad.Propietario = (Propietario)cboPropietario.SelectedItem;
                    _Unidad.Consorcio = (Consorcio)cboConsorcio.SelectedItem;


              





                    if (_Unidad.Id != 0)
                    {

                        _CN_Unidad.EditarUnidad(_Unidad);
                        MessageBox.Show("La Unidad Fue Modificado Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Unidad.InsertarUnidad(_Unidad);
                        MessageBox.Show("La Unidad Fue Agregado Exitosamente!!", "Agregado");
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



            if (txt_numUnidad.Text == string.Empty)
            {
                errorIcono.SetError(txt_numUnidad, "El campo es obligatorio");
                error = false;
            }
            if (txt_piso.Text == string.Empty)
            {
                errorIcono.SetError(txt_piso, "El campo es obligatorio");
                error = false;
            }
            if (txtPorcentaje.Text == string.Empty)
            {
                errorIcono.SetError(txtPorcentaje, "El campo es obligatorio");
                error = false;
            }

            if (txt_gastosmensuales.Text == string.Empty)
            {
                errorIcono.SetError(txt_gastosmensuales, "El campo es obligatorio");
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
            GuardarUnidad();
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_gastosmensuales_KeyPress(object sender, KeyPressEventArgs e)
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
