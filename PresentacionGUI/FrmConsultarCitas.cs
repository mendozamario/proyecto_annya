using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace PresentacionGUI
{
    public partial class FrmConsultarCitas : Form
    {
        SesionService sesionService;
        string psicologoId;
        public FrmConsultarCitas(string identifiacion)
        {
            InitializeComponent();
            sesionService = new SesionService(ConfigConnection.connectionString);
            ConfiguraionInicalGrid();
            psicologoId = identifiacion;
            Consulta();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ConfiguraionInicalGrid()
        {
            DtgCitas.AllowUserToAddRows = false;
            DtgCitas.Columns.Add("columId", "ID Sesion");
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
        private Responce SeleccionDeConsulta(string filtro)
        {
            if (filtro.Equals("Todos"))
            {
                return sesionService.Consultar();
            }

            return sesionService.BuscarPorEstado(filtro);

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
        public void LlenarGrid(List<Sesion> sesiones)
        {
            DtgCitas.Rows.Clear();
           
                foreach (var item in sesiones)
                {
                    DtgCitas.Columns[3].DefaultCellStyle.Format = "dd/mm/yyyy";
                    DtgCitas.Rows.Add(item.IdSesion, item.Paciente.Identificacion, item.Psicologo.Identificacion, item.Fecha, item.Hora, item.Estado);
                }
            DtgCitas.Refresh();
        }

      
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var filtro = CmbFiltro.Text;
            if (filtro.Equals(""))
            {
                MessageBox.Show("Escoja una Opción de Filtrado");
            }
            else
            {
                var respuesta = SeleccionDeConsulta(filtro);
                ValidarRespuestadeConsulta(respuesta);
            }
        }

        private void Consulta()
        {
            var respuesta = sesionService.BuscarPorIdentificacion(psicologoId);
            ValidarRespuestadeConsulta(respuesta);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
