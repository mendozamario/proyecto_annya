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
    public partial class FrmConsultarAgenda : Form
    {
        AgendaService agendaService;
        public FrmConsultarAgenda()
        {
            InitializeComponent();
            agendaService = new AgendaService(ConfigConnection.connectionString);
            ConfiguraionInicalGrid();
            
        }
        private void ConfiguraionInicalGrid()
        {
            DtgSesiones.AllowUserToAddRows = false;
          
            DtgSesiones.Columns.Add("columIdPsicologo", "IdPsicologo");
            DtgSesiones.Columns.Add("columPsicolgoo", "Psicologo");
            DtgSesiones.Columns.Add("columIdPaciente", "IdPaciente");
            DtgSesiones.Columns.Add("culumNombrePaciente", "Paciente");
            DtgSesiones.Columns.Add("columFecha", "Fecha");
            DtgSesiones.Columns.Add("columHora", "Hora");
            DtgSesiones.Columns.Add("columEstado", "Estado");


            DtgSesiones.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DtgSesiones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DtgSesiones.ColumnHeadersDefaultCellStyle.Font =
                new Font(DtgSesiones.Font, FontStyle.Bold);
        }
        private void ValidarRespuestadeConsulta(Responce respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Message, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGrid(respuesta.Agenda);

            }
        }
        public void LlenarGrid(List<Agenda> agenda)
        {
            DtgSesiones.Rows.Clear();
            foreach (var item in agenda)
            {
                DtgSesiones.Rows.Add(item.Psicologo.Identificacion, item.Psicologo.Apellido,item.Sesion.Paciente.Identificacion, item.Sesion.Paciente.Apellido, item.Sesion.Fecha, item.Sesion.Hora, item.Sesion.Estado);   
            }
            DtgSesiones.Refresh();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var respuesta = agendaService.BuscarPorIdentificacion(TextId.Text);
            ValidarRespuestadeConsulta(respuesta);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
