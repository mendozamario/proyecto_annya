using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PresentacionGUI
{
    public partial class FrmConsultarEmpleado : Form
    {
        PsicologoService psicologoService;
        public FrmConsultarEmpleado()
        {
            InitializeComponent();
            psicologoService = new PsicologoService(ConfigConnection.connectionString);
            ConfiguraionInicalGrid();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private Responce SeleccionDeConsulta(string filtro)
        {
            if (filtro.Equals("Todos"))
            {
                return psicologoService.Consultar();
            }
            return psicologoService.Consultar();
        }

        private void ValidarRespuestadeConsulta(Responce respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Message, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGrid(respuesta.Psicologos);
            }
        }
        public void LlenarGrid(List<Psicologo> psicologos)
        {
            DtgEmpleado.Rows.Clear();

            foreach (var item in psicologos)
            {
                DtgEmpleado.Rows.Add(item.TipoIdentificacion, item.Identificacion, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.Email, item.FechaNacimiento, item.Edad, item.Sexo, item.Especializacion);
            }

            DtgEmpleado.Refresh();


        }

        private void ConfiguraionInicalGrid()
        {
            DtgEmpleado.AllowUserToAddRows = false;
            DtgEmpleado.Columns.Add("columTipoId", "TipoId");
            DtgEmpleado.Columns.Add("columId", "Identificacion");
            DtgEmpleado.Columns.Add("columNombre", "Nombre");
            DtgEmpleado.Columns.Add("columApellido", "Apellido");
            DtgEmpleado.Columns.Add("columDireccion", "Direccion");
            DtgEmpleado.Columns.Add("columTelefono", "Telefono");
            DtgEmpleado.Columns.Add("columMail", "E-Mail");
            DtgEmpleado.Columns.Add("columFechaNacimiento", "Fecha Nacimiento");
            DtgEmpleado.Columns.Add("columEdad", "Edad");
            DtgEmpleado.Columns.Add("columSexo", "Sexo");
            DtgEmpleado.Columns.Add("columEspecializacion", "Especializacion");





            DtgEmpleado.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DtgEmpleado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DtgEmpleado.ColumnHeadersDefaultCellStyle.Font =
                new Font(DtgEmpleado.Font, FontStyle.Bold);
        }

        private void TextId_TextChanged(object sender, EventArgs e)
        {
            var respuesta = psicologoService.BuscarPorIdentificacion(TextId.Text);
            ValidarRespuestadeConsulta(respuesta);
        }
    }
}
