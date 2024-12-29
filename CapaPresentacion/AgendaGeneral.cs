using CapaDominio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class AgendaGeneral : Form
    {
        private List<Agenda> ListaAgenda;


        public AgendaGeneral()
        {
            InitializeComponent();
        }

 
        


 
        private void ipbExitAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            CN_Agenda _Agenda = new CN_Agenda();
            Agenda agenda = new Agenda();

            try
            {
                // Validar que la fecha no sea null
                if (dtp_fecha.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Debe seleccionar una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtp_fecha.Value < DateTime.Now.Date) // .Date para comparar solo la fecha sin hora
                {
                    MessageBox.Show("No puede seleccionar una fecha en el pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que la descripción no sea vacía
                if (string.IsNullOrWhiteSpace(rtxtAgendaGeneral.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Asignar valores si la validación es exitosa
                agenda.Fecha = dtp_fecha.Value;
                agenda.Descripcion = rtxtAgendaGeneral.Text.Trim();

                _Agenda.InsertarAgenda(agenda);
                CargarGrilla();

                MessageBox.Show("Agregado exitosamente.", "");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            dtp_fecha.Value = DateTime.Today;

            rtxtAgendaGeneral.Clear();
        }

        private void AgendaGeneral_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgvAgenda);
        }
        private void CargarGrilla()
        {
            CN_Agenda _Agenda = new CN_Agenda();

           

            ListaAgenda = _Agenda.ListaAgenda();

            dgvAgenda.DataSource = ListaAgenda;


        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Agenda _Agenda = new CN_Agenda();

            Agenda seleccionado = null;


            try
            {

                if (dgvAgenda.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Agenda?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Agenda)dgvAgenda.CurrentRow.DataBoundItem;
                        _Agenda.EliminarAgenda(seleccionado.Id);

                        CargarGrilla();
                    }
                }
                   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void ArregloDataGridView(DataGridView dgv_ingresos)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            dgv_ingresos.Columns["id"].Width = 300;
            dgv_ingresos.Columns["Fecha"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Descripcion"].Width = 400; // descripcion_producto 
 

            dgv_ingresos.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_ingresos);
        }
    }
}
