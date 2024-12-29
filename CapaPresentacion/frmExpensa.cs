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
    public partial class frmExpensa : Form
    {


        private List<Expensa> listaExpensas;

        public frmExpensa()
        {
            InitializeComponent();
        }
        private void frmExpensa_Load(object sender, EventArgs e)
        {
            CargarCbo();
            CargarGrilla();
            ArregloDataGridView(dgvExpensa);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Expensa _Expensa = new CN_Expensa();

            // Capturar el ID seleccionado del ComboBox
            int Id = Convert.ToInt32(cboExpensas.SelectedValue);


            listaExpensas = _Expensa.BuscarExpensas(Id);

            dgvExpensa.DataSource = listaExpensas;

        }

        private void CargarCbo()
        {

            CN_Consorcio _Consorcio = new CN_Consorcio();

            try
            {

                cboExpensas.DataSource = _Consorcio.CargarCbo();
                cboExpensas.ValueMember = "Id";
                cboExpensas.DisplayMember = "Nombre";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ArregloDataGridView(DataGridView dgv_propietario)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            dgv_propietario.Columns["Consorcio"].Width = 450;
            dgv_propietario.Columns["Propietario"].Width = 450;
            dgv_propietario.Columns["Unidad"].Width = 250;
            dgv_propietario.Columns["Egreso"].Width = 250;
        
            dgv_propietario.Columns["Monto_Final"].Width = 250;


            dgv_propietario.Columns["Consorcio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Propietario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Unidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_propietario.Columns["Egreso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    
            dgv_propietario.Columns["Monto_Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_propietario);

        }
        private void ipbExitExpensa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporteExpensa_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(cboExpensas.SelectedValue);



            FrmReporteExpensas frmReporte = new FrmReporteExpensas(Id);

            frmReporte.ShowDialog();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            CargarGrilla();
        }
    }
}
