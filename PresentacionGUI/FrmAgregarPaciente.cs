using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmAgregarPaciente : Form
    {
        PacienteService pacienteService;
        public FrmAgregarPaciente()
        {
            InitializeComponent();
            pacienteService = new PacienteService(ConfigConnection.connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TextIdentificacion, "");
            errorProvider1.SetError(TextNombre, "");
            errorProvider1.SetError(TextApellido, "");
            errorProvider1.SetError(CmbSexo, "");
            errorProvider1.SetError(TextMail, "");
        }
        private bool ValidarCampos()
        {
            bool Ok = true;
            if (TextIdentificacion.Text == "")
            {
                Ok = false;
                errorProvider1.SetError(TextIdentificacion, "Ingresar Identificacion");
            }
            if (TextNombre.Text == "")
            {
                Ok = false;
                errorProvider1.SetError(TextNombre, "Ingresar Nombre");
            }
            if (TextApellido.Text == "")
            {
                Ok = false;
                errorProvider1.SetError(TextApellido, "Ingresar apellido");
            }
            if (CmbSexo.SelectedItem == null)
            {
                Ok = false;
                errorProvider1.SetError(CmbSexo, "Seleccione una opcion");
            }
            if (TextMail.Text == "")
            {
                Ok = false;
                errorProvider1.SetError(TextMail, "Ingresar el E-Mail");
            }
            if (Ok == true)
            {
                CrearPaciente();
            }
            return Ok;
        }
        private Paciente CrearPaciente()
        {
            Paciente paciente = new Paciente
            {
                TipoIdentificacion = CmbTipoId.Text,
                Identificacion = int.Parse(TextIdentificacion.Text),
                Nombre = TextNombre.Text,
                Apellido = TextApellido.Text,
                Sexo = CmbSexo.Text,
                FechaNacimiento = DateTimeNacimiento.Value.ToString("MM/dd/yyyy"),
                Telefono = TextTelefono.Text,
                Email = TextMail.Text,
                Direccion = TextDireccion.Text
            };


            return paciente;
        }

        private void LimpiarCampos()
        {
            TextIdentificacion.Text = "";
            TextNombre.Text = "";
            TextApellido.Text = "";
            CmbSexo.SelectedIndex = -1;
            DateTimeNacimiento.Value = DateTime.Today;
            TextTelefono.Text = "";
            TextDireccion.Text = "";
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Campos limpiados exitosamente");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                string message = pacienteService.Guardar(CrearPaciente());
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
