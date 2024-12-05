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
        // Diccionario para almacenar los eventos por fecha
        private Dictionary<DateTime, string> eventosPorFecha;

        public AgendaGeneral()
        {
            InitializeComponent();
            eventosPorFecha = new Dictionary<DateTime, string>();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblFecha.Text= monthCalendar1.SelectionStart.ToShortDateString();


        }


        private void AgendaGeneral_Load(object sender, EventArgs e)
        {
            // Inicializar valores por defecto
            monthCalendar1.TodayDate = DateTime.Today;
            lblFecha.Text = "Fecha seleccionada: " + monthCalendar1.SelectionStart.ToShortDateString();

            // Si ya hay un texto guardado para esa fecha, mostrarlo en el RichTextBox
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            if (eventosPorFecha.ContainsKey(fechaSeleccionada))
            {
                rtxtAgendaGeneral.Text = eventosPorFecha[fechaSeleccionada];
            }
            else
            {
                rtxtAgendaGeneral.Clear(); // Si no hay evento, limpiar el RichTextBox
            }

           


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            string textoEvento = rtxtAgendaGeneral.Text;

            // Guardar el evento en el diccionario de eventos por fecha
            if (eventosPorFecha.ContainsKey(fechaSeleccionada))
            {
                eventosPorFecha[fechaSeleccionada] = textoEvento; // Actualizar evento si ya existe
            }
            else
            {
                eventosPorFecha.Add(fechaSeleccionada, textoEvento); // Agregar nuevo evento
            }

            // Mostrar mensaje de confirmación
            MessageBox.Show("Evento guardado para la fecha: " + fechaSeleccionada.ToShortDateString());

            //Guardar los eventos en un archivo de texto o base de datos
            GuardarEventosEnArchivo();
        }

        // Método para guardar los eventos en un archivo de texto
        private void GuardarEventosEnArchivo()
        {
            string filePath = "eventos.txt";

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var evento in eventosPorFecha)
                {
                    writer.WriteLine($"{evento.Key.ToShortDateString()}: {evento.Value}");
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            rtxtAgendaGeneral.Clear();
        }

        private void ipbExitAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
