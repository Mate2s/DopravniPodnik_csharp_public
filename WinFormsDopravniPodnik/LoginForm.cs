using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDopravniPodnik.model;


namespace WinFormsDopravniPodnik
{
    public partial class LoginForm : Form
    {
        private Form1 mainForm;
        public LoginForm(Form1 mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = tBoxLogin.Text.ToString();
            string password= tBoxPassword.Text.ToString();
            Driver driver = Driver.DoLogin(login, password);
            if (driver == null)
                labelError.Text = Properties.Resources.ErrorPassword;
            else
            {
                mainForm.Driverlogged = driver;
                this.Close();
            }
        }
    }
}
