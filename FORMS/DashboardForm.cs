using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //display the app logo image
            logo_dashboard.Image = Image.FromFile("../../IMAGES/book.png");

            //display the close button image
            button_close.Image = Image.FromFile("../../IMAGES/close.png");

            //display menu images
            button_books.Image = Image.FromFile("../../IMAGES/literature.png");
            button_authors.Image = Image.FromFile("../../IMAGES/author.png");
            button_genres.Image = Image.FromFile("../../IMAGES/tag.png");
            button_circulation.Image = Image.FromFile("../../IMAGES/loop.png");
            button_user.Image = Image.FromFile("../../IMAGES/users.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_user_Click(object sender, EventArgs e)
        {

        }

        private void button_circulation_Click(object sender, EventArgs e)
        {

        }

        private void button_genres_Click(object sender, EventArgs e)
        {

        }

        private void button_authors_Click(object sender, EventArgs e)
        {

        }

        private void button_books_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void lms_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {

            this.Enabled = false;
            //show the login form
            LoginForm lgf = new LoginForm(this);
            lgf.Show();
        }
    }
}
