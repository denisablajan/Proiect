using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Cinema
{
    public partial class Movie_info : Form
    {
        int id;
        string idS, imdbLink, movieGenre;
        OleDbConnection con = new OleDbConnection();

        public Movie_info(int idmovie)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Cinema.Properties.Settings.CinemaConnectionString"].ConnectionString;
            con.ConnectionString = connectionString;
            id = idmovie;
        }

        public void Movie_info_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Movies where id_movie=" + id + "", con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            string[] movies = new string[10];
            while (rdr.Read())
            {
                movies[1] = rdr[1].ToString();
                movies[2] = rdr[2].ToString();
                movies[3] = rdr[3].ToString();
                movies[4] = rdr[4].ToString();
                movies[5] = rdr[5].ToString();
                movies[6] = rdr[6].ToString();
                movies[7] = rdr[7].ToString();
                movies[8] = rdr[8].ToString();
                movies[9] = rdr[9].ToString();
            }
            titleLbl.Text = movies[1];
            //3d
            OleDbCommand cmd3d = new OleDbCommand("select id_movie from Movies where[3D] = True", con);
            OleDbDataReader rdr3d = cmd3d.ExecuteReader();
            idS = id.ToString();
            while (rdr3d.Read())
                if (rdr3d[0].ToString() == idS)
                    threeDLbl.Visible = true;
            yearTb.Text = movies[3];
            //genre
            OleDbCommand cmd2 = new OleDbCommand("select id_genr, genre_name from Genre inner join Movies on Genre.id_genr=Movies.id_gen", con);
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                if (rdr2[0].ToString() == movies[2])
                    movieGenre = rdr2[1].ToString();
            }
            genreTb.Text = movieGenre;
            ageTb.Text = movies[3];
            priceTb.Text = movies[6];
            roomTb.Text = movies[7];
            //picture
            string img = movies[8];
            if (img != "")
                picBox.Load("pic\\" + img);
            yearTb.ForeColor = genreTb.ForeColor = ageTb.ForeColor = priceTb.ForeColor = roomTb.ForeColor = Color.DarkRed;
            imdbLink = movies[9];
            con.Close();
        }

        public void backtomoviesBtn_Click(object sender, EventArgs e)
        {
            Movies movie = new Movies();
            Hide();
            movie.ShowDialog();
        }

        public void imdbLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(imdbLink.Trim('#'));
        }
    }
}
