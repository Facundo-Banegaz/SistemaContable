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
    public partial class frmConsorcio : Form
    {
        private List<Consorcio> ListaConsorcios;
        public frmConsorcio()
        {
            InitializeComponent();
        }

        private void ipbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsorcio_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgvConsorcio);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Consorcio _Consorcio  = new CN_Consorcio();


            ListaConsorcios = _Consorcio.ListaConsorcios();

            dgvConsorcio.DataSource = ListaConsorcios;

        }


        private void ArregloDataGridView(DataGridView dgv_propietario)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            dgv_propietario.Columns["Id"].Width = 100;
            dgv_propietario.Columns["Nombre"].Width = 350;
            dgv_propietario.Columns["Direccion"].Width = 250;
            dgv_propietario.Columns["Cuit"].Width = 250;
            dgv_propietario.Columns["Administrador"].Width = 450;

            dgv_propietario.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Cuit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Administrador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_propietario);

        }


        private void btnNuevoConsorcio_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarConsorcio frmAgregar = new FrmAgregarEditarConsorcio();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btnEditarConsorcio_Click(object sender, EventArgs e)
        {
            Consorcio seleccionado = null;
            if (dgvConsorcio.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Consorcio?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Consorcio)dgvConsorcio.CurrentRow.DataBoundItem;
                    FrmAgregarEditarConsorcio frmEditar = new FrmAgregarEditarConsorcio(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarConsorcio_Click(object sender, EventArgs e)
        {
            CN_Consorcio _CN_Consorcio = new CN_Consorcio();
            Consorcio Seleccionado = null;
            try
            {

                if (dgvConsorcio.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Consorcio?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        Seleccionado = (Consorcio)dgvConsorcio.CurrentRow.DataBoundItem;

                        _CN_Consorcio.EliminarConsorcio(Seleccionado.Id);

                        CargarGrilla();
                    }

                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void BuscarPropietario()
        {
            CN_Consorcio _CN_Consorcio = new CN_Consorcio();

            if (txtBuscarConsorcio.Text == string.Empty)
            {
                CargarGrilla();

            }
            else
            {
                dgvConsorcio.DataSource = _CN_Consorcio.BuscarConsorcio(txtBuscarConsorcio.Text);
            }


        }
        private void txtBuscarConsorcio_TextChanged(object sender, EventArgs e)
        {
            BuscarPropietario();
        }
    } 
}
