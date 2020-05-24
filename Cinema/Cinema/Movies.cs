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

namespace Cinema
{
    public partial class Movies : Form
    {
        OleDbConnection con = new OleDbConnection();
        int idmovie, moviePrice, totalPrice, ticketNo, idroom, placesNo, placesRem;
        string remPlaces="";

        public Movies()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Cinema.accdb;
Persist Security Info=False;";
        }

        public void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void movieBtn_Click(object sender, EventArgs e)
        {
            Movie_info info = new Movie_info(idmovie);
            Hide();
            info.ShowDialog();
        }

        private void movieTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            movieBtn.Visible = true;
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select id_movie, movie_name, price from Movies where movie_name='" + movieTB.Text + "'", con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                idmovie = Convert.ToInt32(rdr[0]);
                moviePrice = Convert.ToInt32(rdr[2]);
            }
            con.Close();
        }

        private void roomsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            idroom = Convert.ToInt32(roomsCB.Text);
            OleDbCommand cmd = new OleDbCommand("select * from Rooms where id_room=" + idroom + "", con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                remPlaces = rdr[1].ToString();
            placesNo = Convert.ToInt32(remPlaces);
            OleDbCommand cmd2 = new OleDbCommand("select id_movie, ticket_nr from Sale where id_movie=" + idmovie + "", con);
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            placesRem = placesNo;
            while (rdr2.Read())
            {
                placesRem -= Convert.ToInt32(rdr2[1].ToString());
            }
            leftPlaceTB.Visible = true;
            leftPlaceLB.Visible = true;
            leftPlaceTB.Text = placesRem.ToString();
            con.Close();
        }

        private void ticketsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketNo = Convert.ToInt32(ticketsCB.Text);
            totalPrice = moviePrice * ticketNo;
            priceTB.Text = totalPrice.ToString();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Sale(id_movie, ticket_nr, movie_date) values (" + idmovie + ", " + ticketNo + ", '" + datePick.Value.Date + "')";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You ordered " + ticketNo + " tickets to " + movieTB.Text + " for " + datePick.Value.ToShortDateString() + ".");
            con.Close();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Movies", con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                movieTB.Items.Add(rdr[1]);
            con.Close();
        }
    }
}
