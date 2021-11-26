using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace PresentacionGUI
{
    public partial class FrmConsultarPaciente : Form
    {
        PacienteService pacienteService;
        int psicologoId;
        public FrmConsultarPaciente(string id)
        {
            InitializeComponent();
            pacienteService = new PacienteService(ConfigConnection.connectionString);
            ConfiguraionInicalGrid();
            psicologoId = int.Parse(id);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       

        private void ConfiguraionInicalGrid()
        {
            DtgPacientes.AllowUserToAddRows = false;
            DtgPacientes.Columns.Add("columTipoId", "TipoId");
            DtgPacientes.Columns.Add("columId", "Identificacion");
            DtgPacientes.Columns.Add("columNombre", "Nombre");
            DtgPacientes.Columns.Add("columApellido", "Apellido");
            DtgPacientes.Columns.Add("columDireccion", "Direccion");
            DtgPacientes.Columns.Add("columTelefono", "Telefono");
            DtgPacientes.Columns.Add("columMail", "E-Mail");
            DtgPacientes.Columns.Add("columFechaNacimiento", "Fecha Nacimiento");
            DtgPacientes.Columns.Add("columEdad", "Edad");
            DtgPacientes.Columns.Add("columSexo", "Sexo");

            DtgPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DtgPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DtgPacientes.ColumnHeadersDefaultCellStyle.Font =
                new Font(DtgPacientes.Font, FontStyle.Bold);
        }
        private Responce SeleccionDeConsulta(string filtro)
        {
            if (filtro.Equals("Todos"))
            {
                return pacienteService.Consultar();
            }
            return pacienteService.BuscarPorGenero(filtro);
        }


        private void ValidarRespuestadeConsulta(Responce respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Message, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGrid(respuesta.Pacientes);
            }
        }
        public void LlenarGrid(List<Paciente> pacientes)
        {
            DtgPacientes.Rows.Clear();

            foreach (var item in pacientes)
            {
                DtgPacientes.Rows.Add(item.TipoIdentificacion,item.Identificacion, item.Nombre, item.Apellido, item.Direccion, 
                    item.Telefono, item.Email, item.FechaNacimiento, item.Edad, item.Sexo);
               
            }
            DtgPacientes.Refresh();

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
    }
}
