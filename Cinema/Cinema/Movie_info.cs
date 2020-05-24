using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace Cinema
{
    public partial class Movie_info : Form
    {
        int id;
        string idS, imdbLink;
        OleDbConnection con = new OleDbConnection();

        public Movie_info(int idmovie)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Cinema.accdb;
Persist Security Info=False;";
            id = idmovie;
        }

        public void Movie_info_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Movies where id_movie=" + id + "", con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                titleLbl.Text = rdr[1].ToString();
                //3d
                OleDbCommand cmd3d = new OleDbCommand("select id_movie from Movies where[3D] = True", con);
                OleDbDataReader rdr3d = cmd3d.ExecuteReader();
                idS = id.ToString();
                while (rdr3d.Read())
                    if (rdr3d[0].ToString() == idS)
                        threeDLbl.Visible = true;
                yearTb.Text = rdr[4].ToString();
                //genre
                OleDbCommand cmd2 = new OleDbCommand("select id_genr, genre_name from Genre inner join Movies on Genre.id_genr=Movies.id_gen", con);
                OleDbDataReader rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    if (rdr2[0].ToString() == rdr[2].ToString())
                        genreTb.Text = rdr2[1].ToString();
                }
                ageTb.Text = rdr[3].ToString();
                priceTb.Text = rdr[7].ToString();
                roomTb.Text = rdr[8].ToString();
                //picture
                string img = rdr["poster"].ToString();
                if (img != "")
                    picBox.Load("pic\\" + img);
                yearTb.ForeColor = genreTb.ForeColor = ageTb.ForeColor = priceTb.ForeColor = roomTb.ForeColor = Color.DarkRed;
                imdbLink = rdr["imdblink"].ToString();
            }
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
            Process.Start(imdbLink);
        }
    }
}
