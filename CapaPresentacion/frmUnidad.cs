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
    public partial class frmUnidad : Form
    {
        private List<Unidad> ListaUnidades;


        public frmUnidad()
        {
            InitializeComponent();

        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgvUnididades);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Unidad _Unidad  = new CN_Unidad();


            ListaUnidades = _Unidad.ListaUnidades();

            dgvUnididades.DataSource = ListaUnidades;

        }


        private void ArregloDataGridView(DataGridView dgv_unidades)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            // Configuración de las columnas del DataGridView
            
            dgv_unidades.Columns["Id"].Width = 100;
            dgv_unidades.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv_unidades.Columns["NumeroUnidad"].Width = 200;
            dgv_unidades.Columns["NumeroUnidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_unidades.Columns["Piso"].Width = 150;
            dgv_unidades.Columns["Piso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv_unidades.Columns["Porcentaje"].Width = 150;
            dgv_unidades.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_unidades.Columns["GastosMensuales"].Width = 200;
            dgv_unidades.Columns["GastosMensuales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

    
            dgv_unidades.Columns["Propietario"].Width = 500;
            dgv_unidades.Columns["Propietario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv_unidades.Columns["Consorcio"].Width = 500;
            dgv_unidades.Columns["Consorcio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        

            _Metodos.AlternarColor(dgv_unidades);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            CN_Unidad _Unidad   = new CN_Unidad();

            Unidad Seleccionado = null;
            try
            {

                if (dgvUnididades.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Unidad?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        Seleccionado = (Unidad)dgvUnididades.CurrentRow.DataBoundItem;

                        _Unidad.EliminarUnidad(Seleccionado.Id);

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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Unidad seleccionado = null;
            if (dgvUnididades.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Unidad?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Unidad)dgvUnididades.CurrentRow.DataBoundItem;
                    FrmAgregarEditarUnidad frmEditar = new FrmAgregarEditarUnidad(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarUnidad frmAgregar = new FrmAgregarEditarUnidad();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }
        private void BuscarUnidad()
        {
           CN_Unidad _Unidad = new CN_Unidad();

            if (txt_Buscar.Text == string.Empty)
            {
                CargarGrilla();

            }
            else
            {
                dgvUnididades.DataSource = _Unidad.UnidadBuscar(txt_Buscar.Text);
            }


        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUnidad();
        }

        private void ipbExitPropietario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
