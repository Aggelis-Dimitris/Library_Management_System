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
    }
}
