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
    public partial class Movie_info : Form
    {
        public Movie_info()
        {
            InitializeComponent();
        }

        private void backtomoviesBtn_Click(object sender, EventArgs e)
        {
            Movies movie = new Movies();
            Hide();
            movie.ShowDialog();
        }
    }
}
