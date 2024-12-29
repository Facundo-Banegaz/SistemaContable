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
    public partial class frmPropietarioRegistro : Form
    {

        private List<Propietario> ListaPropietarios;
        public frmPropietarioRegistro()
        {
            InitializeComponent();
            Text = "Gestion Propietario:";
        }

        private void frmPropietarioRegistro_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgvPropietariosRegistro);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Propietario _Propietario = new CN_Propietario();


            ListaPropietarios = _Propietario.ListaPropietario();

            dgvPropietariosRegistro.DataSource = ListaPropietarios;

            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgvPropietariosRegistro.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void ArregloDataGridView(DataGridView dgv_propietario)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
         


            dgv_propietario.Columns["Id"].Width = 100;
            dgv_propietario.Columns["ApyNom"].Width = 350;
            dgv_propietario.Columns["NumeroDocumento"].Width = 250;
            dgv_propietario.Columns["Telefono"].Width = 250;
            dgv_propietario.Columns["Email"].Width = 300;

            dgv_propietario.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["ApyNom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["NumeroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_propietario);

        }


        private void BuscarPropietario()
        {
            CN_Propietario _Propietario = new CN_Propietario();

            if (txtBuscarPropRegistro.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgvPropietariosRegistro.DataSource = _Propietario.PropietarioBuscarApellido(txtBuscarPropRegistro.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgvPropietariosRegistro.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarPropietario();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtBuscarPropRegistro.Clear();
            CargarGrilla();
        }

        private void ipbExitPropietario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
