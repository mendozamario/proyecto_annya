using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entity;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        Credencial User;
        public FrmPrincipal(Credencial credencial)
        {
            InitializeComponent();
            User = credencial;
            CustomizeDesing();
        }

        public void CustomizeDesing()
        {
            if (User.Type == "Administrador")
            {
                BtnEmpleados.Visible = true;
                BtnSesion.Visible = false;
            }
            if (User.Type == "Psicologo")
            {
                BtnSesion.Visible = true;
                BtnEmpleados.Visible=false;
            }
            PnlSubMenuPacientes.Visible = false;
            PnlSubMenuCitas.Visible = false;
            PnlSubMenuSesion.Visible = false;
            PnlSubMenuEmpleados.Visible = false;
        }

        public void HideSubMenu()
        {
            if (PnlSubMenuPacientes.Visible == true)
                PnlSubMenuPacientes.Visible = false;
            if (PnlSubMenuCitas.Visible == true)
                PnlSubMenuCitas.Visible = false;
            if (PnlSubMenuSesion.Visible == true)
                PnlSubMenuSesion.Visible = false;
            if (PnlSubMenuEmpleados.Visible == true)
                PnlSubMenuEmpleados.Visible = false;
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlFormularioHijo.Controls.Add(childForm);
            PnlFormularioHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {

        }
        private void BtnHorario_Click(object sender, EventArgs e)
        {
            PnlFormularioHijo.BringToFront();
        }       
        private void BtnPacientes_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(PnlSubMenuPacientes);
        }

        private void BtnCitas_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(PnlSubMenuCitas);
        }

        private void BtnSesion_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(PnlSubMenuSesion);
        }

        private void BtnEmpleados_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(PnlSubMenuEmpleados);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmAgregarPaciente());
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmConsultarPaciente(User.Id));
        }

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmAgregarEmpleado());
        }

        private void BtnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmConsultarEmpleado());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmConsultarCitas(User.Id));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAgendamiento());
        }

        private void BtnAgregarNotas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAgregarNotas()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultarAgenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmConsultarAgenda());
        }
    }
}
