using System;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Cinema
{
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Cinema.accdb;
Persist Security Info=False;";
        }
        private void goBtn_Click(object sender, EventArgs e)
        {
            int ct = 0;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select email, password from Clients where email='" + authemailTB.Text + "' and password='" + authpasswordTB.Text + "' ";
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                ct++;
            if (ct > 0) 
            {
                con.Close();
                Reservation reserve = new Reservation();
                Hide();
                reserve.ShowDialog();
            }
            else
            {
                con.Close();
                MessageBox.Show("This client does not exist!");
                authemailTB.Text = authpasswordTB.Text = "";
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int ct = 0;
            con.Open();
            string sql1 = "select * from Clients where email='" + emailTB.Text + "' and password='" + passTB.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql1, con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) ct++;
            if (ct > 0)
            {
                MessageBox.Show("This client already exists!");
                emailTB.Text = "";
                passTB.Text = "";
                repassTB.Text = "";
                rdr.Close();
                con.Close();
            }
            else
            {
                string sql2 = "";
                if (fnameTB.Text == "" || lnameTB.Text == "" || addressTB.Text == "" || emailTB.Text == "" || passTB.Text == "" || repassTB.Text == "")
                {
                    MessageBox.Show("Complete all fields!");
                    con.Close();
                }
                else
                {
                    if (passTB.Text == repassTB.Text)
                    {
                        sql2 = "INSERT INTO Clients(first_name,last_name,[address],[email],[password]) VALUES (@FirstName,@LastName,@Address,@Email,@Password)";
                        OleDbCommand cmd2 = new OleDbCommand(sql2, con);
                        cmd2.Parameters.Add(new OleDbParameter("@FirstName", fnameTB.Text));
                        cmd2.Parameters.Add(new OleDbParameter("@LastName", lnameTB.Text));
                        cmd2.Parameters.Add(new OleDbParameter("@Address", addressTB.Text));
                        cmd2.Parameters.Add(new OleDbParameter("@Email", emailTB.Text));
                        cmd2.Parameters.Add(new OleDbParameter("@Password", passTB.Text));
                        cmd2.ExecuteNonQuery();
                        rdr.Close();
                        con.Close();
                        MessageBox.Show("Account created! You can turn to the Sign in page.");
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match!");
                        passTB.Text = "";
                        repassTB.Text = "";
                        rdr.Close();
                        con.Close();
                    }
                }
            }
        }
    }
}
