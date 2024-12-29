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
    public partial class frmAdmin : Form
    {

        private List<Administrador> ListaAdministradores;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void ipbExitAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
           CN_Administrador _Administrador = new CN_Administrador();


            ListaAdministradores = _Administrador.ListaAdministrador();

            dgvAdmin.DataSource = ListaAdministradores;

        }


        private void ArregloDataGridView(DataGridView dgv_unidades)
        {
            // Lógica del DataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            // Configuración de las columnas del DataGridView

            dgv_unidades.Columns["Id"].Width = 150;
            dgv_unidades.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv_unidades.Columns["Matricula"].Width = 250;
            dgv_unidades.Columns["Matricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_unidades.Columns["Dni"].Width = 250;
            dgv_unidades.Columns["Dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

          
            dgv_unidades.Columns["ApyNom"].Width = 300;
            dgv_unidades.Columns["ApyNom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

         
            dgv_unidades.Columns["NombreUsuario"].Width = 300;
            dgv_unidades.Columns["NombreUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_unidades.Columns["Clave"].Width = 250;
            dgv_unidades.Columns["Clave"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_unidades.Columns["Acceso"].Width = 250;
            dgv_unidades.Columns["Acceso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_unidades.Columns["Telefono"].Width = 200;
            dgv_unidades.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


         

            _Metodos.AlternarColor(dgv_unidades);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
                        CargarGrilla();
            ArregloDataGridView(dgvAdmin);
        }

        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
            frmAgregarEditarAdmin frmAgregar = new frmAgregarEditarAdmin();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            Administrador seleccionado = null;
            if (dgvAdmin.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Unidad?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Administrador)dgvAdmin.CurrentRow.DataBoundItem;
                    frmAgregarEditarAdmin frmEditar = new frmAgregarEditarAdmin(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           CN_Administrador _Administrador = new CN_Administrador();

            Administrador Seleccionado = null;
            try
            {

                if (dgvAdmin.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Admin?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        Seleccionado = (Administrador)dgvAdmin.CurrentRow.DataBoundItem;

                        _Administrador.EliminarAdministrador(Seleccionado.Id);

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
        private void BuscarAdmin()
        {
            CN_Administrador _Administrador = new CN_Administrador();   

            if (txtBuscarAdmin.Text == string.Empty)
            {
                CargarGrilla();
            }
            else
            {
                dgvAdmin.DataSource = _Administrador.AdministradorBuscarNombre(txtBuscarAdmin.Text);
            }


        }
        private void txtBuscarAdmin_TextChanged(object sender, EventArgs e)
        {
            BuscarAdmin();
        }
    }
}
