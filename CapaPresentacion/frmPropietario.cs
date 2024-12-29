using CapaDominio;
using CapaNegocio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CapaPresentacion
{
    public partial class frmPropietario : Form
    {

        private List<Propietario> ListaPropietarios;



        public frmPropietario()
        {
            InitializeComponent();
        }


    

        private void frmPropietario_Load(object sender, EventArgs e)
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


        private void ipbExitPropietario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Propietario seleccionado = null;
            if(dgvPropietariosRegistro.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Propietario?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Propietario)dgvPropietariosRegistro.CurrentRow.DataBoundItem;
                    FrmAgregarEditarPropietario frmEditar = new FrmAgregarEditarPropietario(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            CN_Propietario _CN_Propietario = new CN_Propietario();
            Propietario Seleccionado= null;
            try
            {

                if(dgvPropietariosRegistro.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Propietario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        Seleccionado = (Propietario)dgvPropietariosRegistro.CurrentRow.DataBoundItem;

                        _CN_Propietario.EliminarPropietario(Seleccionado.Id);

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
            CN_Propietario _Propietario = new CN_Propietario();

            if (txt_Buscar.Text == string.Empty)
            {
                CargarGrilla();

            }
            else
            {
                dgvPropietariosRegistro.DataSource = _Propietario.PropietarioBuscarApellido(txt_Buscar.Text);
            }


        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPropietario();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarPropietario frmAgregar = new FrmAgregarEditarPropietario();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }
    }
}
