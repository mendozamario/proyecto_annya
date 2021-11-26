using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
namespace PresentacionGUI
{
    public partial class FrmAgregarEmpleado : Form
    {
        PsicologoService psicologoService;
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
            TextEspecialidad.Visible = false;
            LblEspecialidad.Visible = false;
            psicologoService = new PsicologoService(ConfigConnection.connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Psicologo CrearPsicologo()
        {
           
            Psicologo psicologo = new Psicologo
            {
                TipoIdentificacion = CmbTipoId.Text,
                Identificacion = int.Parse(TextIdentificacion.Text),
                Nombre = TextNombre.Text,
                Apellido = TextApellido.Text,
                Sexo = CmbSexo.Text,
                FechaNacimiento = DateTimeNacimiento.Value.ToString("MM/dd/yyyy"),
                Telefono = TextMovil.Text,
                Email = TextMail.Text,
                Direccion = TextDireccion.Text,
                Especializacion = TextEspecialidad.Text
            };

            psicologo.CalcularEdad();
            
            return psicologo;
        }
        private void LimpiarCampos()
        {
            TextIdentificacion.Text = "";
            TextNombre.Text = "";
            TextApellido.Text = "";
            CmbSexo.SelectedIndex = -1;
            DateTimeNacimiento.Value = DateTime.Today;
            TextMovil.Text = "";
            TextDireccion.Text = "";
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
            if(TextIdentificacion.Text == "")
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
            if(TextMail.Text == "")
            {
                Ok = false;
                errorProvider1.SetError(TextMail, "Ingresar el E-Mail");
            }
            if (Ok == true)
            {
                CrearPsicologo();
            }
            return Ok;
        }
        private void ValidarEspecialidad()
        {
            if (CheckEspecialidad.Checked == true)
            {
                TextEspecialidad.Visible = true;
                LblEspecialidad.Visible = true;
            }
            else
            {
                LblEspecialidad.Visible = false;
                TextEspecialidad.Visible = false;
            }
        }

        private void CheckEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            ValidarEspecialidad();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                string message = psicologoService.Guardar(CrearPsicologo());
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Campos limpiados exitosamente");
        }
    }
}