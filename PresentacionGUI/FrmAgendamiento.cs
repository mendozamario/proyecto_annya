using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PresentacionGUI
{

    public partial class FrmAgendamiento : Form
    {
        bool validar;
        SesionService sesionService;
        PacienteService pacienteService;
        AgendaService agendaService;
        int Id;

        public FrmAgendamiento()
        {
            InitializeComponent();
            sesionService = new SesionService(ConfigConnection.connectionString);
            pacienteService = new PacienteService(ConfigConnection.connectionString);
            agendaService = new AgendaService(ConfigConnection.connectionString);
            ConfiguraionInicalGrid();
            CargarGrid();
            DateTimePcikerFormat();
        }

        private void DateTimePcikerFormat()
        {
            DateTime todayDate = DateTime.Now;
            DtpFecha.MinDate = todayDate;
        }

        private void ValidarFecha()
        {

            if (DtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("Elija una fecha superior a la actual");
                validar = false;
            }
            else
            {
                validar = true;
            }
        }
        private void ConfiguraionInicalGrid()
        {
            DtgCitas.AllowUserToAddRows = false;
            DtgCitas.Columns.Add("columId", "Identificacion");
            DtgCitas.Columns.Add("columIdPaciente", "IdPaciente");
            DtgCitas.Columns.Add("columIdPsicologo", "IdPsicologo");
            DtgCitas.Columns.Add("columFecha", "Fecha");
            DtgCitas.Columns.Add("columHora", "Hora");
            DtgCitas.Columns.Add("columEstado", "Estado");


            DtgCitas.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DtgCitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DtgCitas.ColumnHeadersDefaultCellStyle.Font =
                new Font(DtgCitas.Font, FontStyle.Bold);
        }
        private void FrmAgendamiento_Load(object sender, EventArgs e)
        {
            CmbPsicologos.DataSource = sesionService.ListadoPsicologos();
            CmbPsicologos.DisplayMember = "ApellidoPsicologo";
            CmbPsicologos.ValueMember = "IdPsicologo";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private Sesion CrearCita()
        {

            Paciente paciente = new Paciente
            {
                Identificacion = int.Parse(TextCedulaPaciente.Text)
            };
            Psicologo psicologo = new Psicologo
            {
                Identificacion = (int)CmbPsicologos.SelectedValue
            };

            Sesion sesion = new Sesion
            {
                Paciente = paciente,
                Psicologo = psicologo,
                Fecha = DtpFecha.Value.ToString("MM/dd/yyyy"),
                Hora = CmbHora.Text,
                Estado = "Pendiente"
                
            };
            

            return sesion;

        }

        private Agenda CrearAgenda()
        {
            Psicologo psicologo = new Psicologo
            {
                Identificacion = (int)CmbPsicologos.SelectedValue
            };
            Sesion sesion = new Sesion
            {
                IdSesion = Id + 1
            };

            Agenda agenda = new Agenda
            {
                
                Psicologo = psicologo,
                Sesion = sesion
            };
            
            return agenda;
        }



        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            ValidarFecha();
            HoursValidation();
            if (validar == true)
            {
                string message = sesionService.Guardar(CrearCita());
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBox.Show(message, caption, buttons);
                CrearAgendas();
            }

        }
        private void CrearAgendas()
        {
            string message = agendaService.Guardar(CrearAgenda());
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBox.Show(message, caption, buttons);
        }
        private void ValidarRespuestadeConsulta(Responce respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Message, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarText(respuesta.Pacientes);
            }
        }
        private void ValidarRespuestadeConsultaSesion(Responce respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Message, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGrid(respuesta.Sesion);
            }
        }
        public void LlenarText(List<Paciente> pacientes)
        {
            foreach (var item in pacientes)
            {
                TextCedulaPaciente.Text = (item.Identificacion).ToString();
                TextNombre.Text = item.Nombre;
                TextApellido.Text = item.Apellido;
                TextEdad.Text = item.Edad.ToString();
            }

        }

        public void LlenarGrid(List<Sesion> sesiones)
        {
            DtgCitas.Rows.Clear();
            foreach (var item in sesiones)
            {
                DtgCitas.Rows.Add(item.IdSesion, item.Paciente.Identificacion, item.Psicologo.Identificacion, item.Fecha, item.Hora, item.Estado);
                Id = item.IdSesion;
            }
            
            DtgCitas.Refresh();
        }
        private void TextCedula_TextChanged(object sender, EventArgs e)
        {

        }
        private void CargarGrid()
        {
            var respuesta = sesionService.Consultar();
            ValidarRespuestadeConsultaSesion(respuesta);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var respuesta = pacienteService.BuscarPorIdentificacion(TextCedula.Text);
            ValidarRespuestadeConsulta(respuesta);
        }

        private void HoursValidation()
        {
            var response = sesionService.ConsultarFecha(DtpFecha.Value.ToString("MM/dd/yyyy"));
            foreach (var item in response.Sesion)
            {
                if (item.Hora == CmbHora.Text)
                {
                    MessageBox.Show("La hora no se encuentra disponible, por favor pruebe con una distinta");
                }else
                {
                    validar = true;
                }
            }
        }
    }
}