using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System.FORMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pictureBoxUser.Image = Image.FromFile("../../IMAGES/user.jpg");
            pictureBoxPass.Image = Image.FromFile("../../IMAGES/lock.jpg");
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Manipulate the dashboard form from the login form

        private DashboardForm dashF = null;

        public LoginForm(DashboardForm sourceForm)
        {
            dashF = sourceForm as DashboardForm;
            InitializeComponent();
        }


        //The login button
        private void button_login_Click(object sender, EventArgs e)
        {

        }
    }
}
