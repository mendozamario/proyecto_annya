using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PresentacionGUI
{
    public partial class FrmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        CredencialService credencialService;
        Credencial credencial;
        public FrmLogin()
        {
            this.ClientSize = new System.Drawing.Size(797, 529);
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            credencialService = new CredencialService(ConfigConnection.connectionString);
        }
        private void PasswordField()
        {
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';
            TxtPassword.MaxLength = 20;
        }
        private bool Validation()
        {
            Responce responseCredencial = credencialService.Consultar(TxtIdentificacion.Text);
            Console.WriteLine(responseCredencial.Message);
            credencial = responseCredencial.Credencial;
            string password = Seguridad.Decode(credencial.Password);
            bool response;
            if (TxtIdentificacion.Text.Equals(credencial.Id) && TxtPassword.Text.Equals(password))
            {
                response = true;
            }else
            {
                response = false;
            }
            return response;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtUsername_Click;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = "";
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnLogin_Click(sender,e);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool response = Validation();
            if (response == true)
            {
                FrmPrincipal frm = new FrmPrincipal(credencial);
                frm.Show();
            }else
            {
                MessageBox.Show("Su identificación o contraseña no estan escritas de manera correcta", "Alerta", MessageBoxButtons.OKCancel);
            }
        }
    }
}

