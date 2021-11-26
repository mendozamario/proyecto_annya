using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmAgregarNotas : Form
    {
        SesionService sesionService;
        NotasService notasSesion;
        HistorialSesion historialSesion;
        public FrmAgregarNotas()
        {
            InitializeComponent();
            sesionService = new SesionService(ConfigConnection.connectionString);
            notasSesion = new NotasService(ConfigConnection.connectionString);
            ConfiguraionInicalGrid();
        }

        private void TextIdSesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void ConfiguraionInicalGrid()
        {
            DtgCitas.AllowUserToAddRows = false;
            DtgCitas.Columns.Add("columId", "ID Sesion");
            DtgCitas.Columns.Add("columIdPaciente", "IdPaciente");
            DtgCitas.Columns.Add("columFecha", "Fecha");
            DtgCitas.Columns.Add("columHora", "Hora");
            DtgCitas.Columns.Add("columEstado", "Estado");


            DtgCitas.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DtgCitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DtgCitas.ColumnHeadersDefaultCellStyle.Font =
                new Font(DtgCitas.Font, FontStyle.Bold);
        }
        public void LlenarGrid(List<Sesion> sesiones)
        {
            DtgCitas.Rows.Clear();

            foreach (var item in sesiones)
            {
                DtgCitas.Columns[2].DefaultCellStyle.Format = "dd/mm/yyyy";
                DtgCitas.Rows.Add(item.IdSesion, item.Paciente.Identificacion, item.Fecha, item.Hora, item.Estado);
            }
            DtgCitas.Refresh();
        }
        private void ValidarRespuestadeConsulta(Responce respuetsa)
        {
            if (respuetsa.Error)
            {
                MessageBox.Show(respuetsa.Message, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGrid(respuetsa.Sesion);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var respuesta = sesionService.BuscarPorIdentificacionPsicologo(TextId.Text);
            ValidarRespuestadeConsulta(respuesta);
        }
        private NotasSesion CrearNota()
        {
            Sesion sesion = new Sesion
            {
                IdSesion = Convert.ToInt32(DtgCitas.SelectedRows[0].Cells[0].Value)
            };
            NotasSesion notasSesion = new NotasSesion
            {
                Sesion = sesion,
                Nota = TextNotas.Text,
                Diagnostico = TextDiagnostico.Text
            };
            return notasSesion;
        }
        private HistorialSesion CrearHistorial()
        {
            Paciente paciente = new Paciente
            {
                Identificacion = Convert.ToInt32(DtgCitas.SelectedRows[0].Cells[2].Value)
            };
            Sesion sesion = new Sesion
            {
                Paciente = paciente,
                IdSesion = Convert.ToInt32(DtgCitas.SelectedRows[0].Cells[0].Value)
            };
            
            HistorialSesion historial = new HistorialSesion
            {
                IdHistorial = 0,
                Sesion = sesion
            };
            return historial;
        }

        
        private void DtgCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DtgCitas.SelectedRows[0].Cells[0].Value);
                string Estado = Convert.ToString(DtgCitas.SelectedRows[0].Cells[4].Value);
                if (Estado.ToUpper().Equals("PENDIENTE"))
                {
                    TextNotas.Enabled = true;
                    TextDiagnostico.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string message = notasSesion.Guardar(CrearNota());

            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
