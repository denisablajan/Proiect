using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        public void login_Click(object sender, EventArgs e)
        {
            Login client = new Login();
            Hide();
            client.ShowDialog();
        }

        public void movie_Click(object sender, EventArgs e)
        {
            Movies movie = new Movies();
            Hide();
            movie.ShowDialog();
        }
    }
}
