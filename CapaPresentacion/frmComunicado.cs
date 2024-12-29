using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace CapaPresentacion
{
    public partial class frmComunicado : Form
    {

        const string Usuario = "steffiludemann@gmail.com";
        const string Password = "zbka ujtj mgqn gswi";


        public frmComunicado()
        {
            InitializeComponent();
        }

        private void ipbExitComunicado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarComunicado_Click(object sender, EventArgs e)
        {
            string Error = "";
            StringBuilder messagebuilder = new StringBuilder();
            messagebuilder.Append(rtxtComunicado.Text.Trim());
            EnviarCorreo(messagebuilder, DateTime.Now, txtEmisor.Text.Trim(), txtEnviar.Text.Trim(), txtAsunto.Text.Trim(), out Error);

            Limpiar();
        }

        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnviar, string Emisor, string Propietario, string Asunto, out string error)
        {
            error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("este correo ha sido enviado el dia {0:dd/MM/yyyy}", FechaEnviar));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Emisor);
                mail.To.Add(Propietario);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString(); //debo convertirlo a string xq es string builder
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                error = "Exito";
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                error = "error: " + ex.Message;
                MessageBox.Show(error);
                return;
            }
        }
        private void Limpiar()
        {
            txtEnviar.Clear();
            txtAsunto.Clear();
            rtxtComunicado.Clear();
        }


    }
}
