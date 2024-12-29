using CapaDominio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEgreso : Form
    {
        private List<TextBox> textBoxList;
        private float totalCalculado;
        public frmEgreso()
        {
            InitializeComponent();

            textBoxList = new List<TextBox>
            {
            txtAportesF931,
            txtSueldoEncargado,
            txtDGRT,
            txtAdmin,
            txtAgua,
            txtcontador,
            txtFateryh,
            txtSeguro,
            txtSueldoEncargado,
            txtSuterh,
            txtEdet,
            txtGastos,
            txtSeracarh,
            txt_descripcion,
            txt_gastos_varios,
            txt_fumigacion,
            txt_limpieza,
            txt_remitos

            };

            foreach (var textBox in textBoxList)
            {
                textBox.TextChanged += (s, e) => ActualizarTotal();
            }
        }

        private void ipbExitEgreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEgreso_Load(object sender, EventArgs e)
        {

            CargarCbo();
        }



        private void CargarCbo()
        {

            CN_Consorcio _Consorcio = new CN_Consorcio();
            try
            {



                cboConsorcio.DataSource = _Consorcio.CargarCbo();
                cboConsorcio.ValueMember = "Id";
                cboConsorcio.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw;
            }
        }


        private void Limpiar()
        {
            txtAportesF931.Clear();
            txtSueldoEncargado.Clear();
            txtDGRT.Clear();
            txtAdmin.Clear();
            txtAgua.Clear();
            txtcontador.Clear();
            txtFateryh.Clear();
            txtSeguro.Clear();
            txtSueldoEncargado.Clear();
            txtSuterh.Clear();
            txtEdet.Clear();
            txtGastos.Clear();
            txtSeracarh.Clear();
            dtp_fecha.Value = DateTime.Today;
            txt_descripcion.Clear();
            txt_gastos_varios.Clear();
            txt_fumigacion.Clear();
            txt_gastos_varios.Clear();
            txt_limpieza.Clear();
            txt_remitos.Clear();
        }

        private void btnLimpiarEgreso_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool ValidarVacio()
        {
            bool error = true;


            if (txtAdmin.Text == string.Empty)
            {
                errorIcono.SetError(txtAdmin, "El campo es obligatorio");
                error = false;
            }
            else if (txtAportesF931.Text == string.Empty)
            {
                errorIcono.SetError(txtAportesF931, "El campo es obligatorio");
                error = false;
            }
            else if (dtp_fecha.Value == DateTime.MinValue)
            {
                errorIcono.SetError(dtp_fecha, "Debe completar el campo Fecha");
                error = false;
            }
            else if (cboConsorcio.SelectedItem == null)
            {
                errorIcono.SetError(cboConsorcio, "Debe completar el campo");
                error = false;
            }
            else if (txtSueldoEncargado.Text == string.Empty)
            {
                errorIcono.SetError(txtSueldoEncargado, "El campo es obligatorio");
                error = false;
            }
            else if (txt_descripcion.Text == string.Empty)
            {
                errorIcono.SetError(txt_descripcion, "El campo es obligatorio");
                error = false;
            }
            else if (txtDGRT.Text == string.Empty)
            {
                errorIcono.SetError(txtDGRT, "Debe completar el campo");
                error = false;
            }
            else if (txtAgua.Text== string.Empty)
            {
                errorIcono.SetError(txtAgua, "Debe completar el campo");
                error = false;
            }
            else if (txtcontador.Text == string.Empty)
            {
                errorIcono.SetError(txtcontador, "El campo es obligatorio");
                error = false;
            }
            else if (txtFateryh.Text == string.Empty)
            {
                errorIcono.SetError(txtFateryh, "El campo es obligatorio");
                error = false;
            }
            else if (txtSeguro.Text == string.Empty)
            {
                errorIcono.SetError(txtSeguro, "Debe completar el campo");
                error = false;
            }
            else if (txtSueldoEncargado.Text == string.Empty)
            {
                errorIcono.SetError(txtSueldoEncargado, "Debe completar el campo");
                error = false;
            }
            else if (txtSuterh.Text == string.Empty)
            {
                errorIcono.SetError(txtSuterh, "El campo es obligatorio");
                error = false;
            }
            else if (txtEdet.Text == string.Empty)
            {
                errorIcono.SetError(txtEdet, "El campo es obligatorio");
                error = false;
            }
            else if (txtGastos.Text == string.Empty)
            {
                errorIcono.SetError(txtGastos, "Debe completar el campo");
                error = false;
            }
            else if (txtSeracarh.Text == string.Empty)
            {
                errorIcono.SetError(txtSeracarh, "Debe completar el campo");
                error = false;
            }
            else if (txt_gastos_varios.Text == string.Empty)
            {
                errorIcono.SetError(txt_gastos_varios, "El campo es obligatorio");
                error = false;
            }
            else if (txt_fumigacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_fumigacion, "El campo es obligatorio");
                error = false;
            }
            else if (txt_remitos.Text == string.Empty)
            {
                errorIcono.SetError(txt_remitos, "Debe completar el campo");
                error = false;
            }
            else if (txt_limpieza.Text == string.Empty)
            {
                errorIcono.SetError(txt_limpieza, "Debe completar el campo");
                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void GuardarEgreso()
        {
            try
            {
                // Validar que los campos esenciales estén completos y sean válidos
                if (ValidarVacio())
                {
                    // Crear instancia de Egreso con datos del formulario
                    Egreso egreso = new Egreso
                    {
                        Descripcion = txt_descripcion.Text,
                        Monto = totalCalculado,
                        FechaPublicacion = dtp_fecha.Value,
                        Consorcio = new Consorcio { Id = int.Parse(cboConsorcio.SelectedValue.ToString()) }
                    };

                    // Crear instancia de TipoEgreso con datos del formulario
                    TipoEgreso tipoEgreso = new TipoEgreso
                    {
                        PagoPortero = float.Parse(txtSueldoEncargado.Text),
                        AportesF931 = float.Parse(txtAportesF931.Text),
                        Suterh = float.Parse(txtSuterh.Text),
                        Fateryh = float.Parse(txtFateryh.Text),
                        Searcharh = float.Parse(txtSeracarh.Text),
                        Edet = float.Parse(txtEdet.Text),
                        Sat = float.Parse(txtAgua.Text),
                        HonorariosContador = float.Parse(txtcontador.Text),
                        HonorariosAdministrador = float.Parse(txtSeguro.Text),
                        DGRT = float.Parse(txtDGRT.Text),
                        Seguro = float.Parse(txtSeguro.Text),
                        Gastos_Bancarios = float.Parse(txtGastos.Text),
                        Fumigacion = float.Parse(txt_fumigacion.Text),
                        Remitos = float.Parse(txt_remitos.Text),
                        Prod_Limpieza = float.Parse(txt_limpieza.Text),
                        GastosVarios = float.Parse(txt_gastos_varios.Text),



                        Egreso = new Egreso() // Para asociar el ID capturado más adelante
                    };

                    // Llamar al procedimiento para guardar los datos
                    CN_Egreso negocioEgreso = new CN_Egreso();
                    negocioEgreso.InsertarEgreso(egreso, tipoEgreso);
                    Limpiar();
                    MessageBox.Show("Egreso guardado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el egreso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnAgregarEgreso_Click(object sender, EventArgs e)
        {
            GuardarEgreso();
        }

        private void txtSueldoEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAportesF931_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDGRT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtFateryh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void ActualizarTotal()
        {
            // Sumar todos los valores de los TextBox en la lista
            totalCalculado = textBoxList.Sum(tb => ObtenerValorNumerico(tb));



            // Mostrar el total en el Label con formato de moneda en pesos argentinos
            var culturaArgentina = new CultureInfo("es-AR"); // Cultura específica de Argentina
            lbl_total.Text = $"{totalCalculado.ToString("C", culturaArgentina)}";
        }

        private int ObtenerValorNumerico(TextBox textBox)
        {
            // Intenta convertir el texto a un número, si no es válido, retorna 0
            return int.TryParse(textBox.Text, out int valor) ? valor : 0;
        }

        private void txtSeracarh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSuterh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtGastos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcontador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_gastos_varios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_fumigacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_remitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_limpieza_KeyPress(object sender, KeyPressEventArgs e)
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
