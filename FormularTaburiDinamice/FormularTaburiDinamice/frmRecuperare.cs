using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FormularTaburiDinamice
{
    public partial class frmRecuperare : Form
    {
        string sirConectare = System.Configuration.ConfigurationManager.ConnectionStrings["sirConfigurareDB"].ConnectionString;
        public frmRecuperare()
        {
            InitializeComponent();

        }
        private void frmRecuperare_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            lblNumeUtilizator.Visible = false;
            lblParola.Visible = false;
            if (Auxiliare.Limba == 2)
            {
                label1.Text = "Enter Email adress:";
                label2.Text = "User name:";
                label3.Text = "Password:";
                btnRecuperare.Text = "Recover!";
            }
        }

        private void btnRecuperare_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(sirConectare))
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                string sirSQL = "SELECT * FROM Utilizatori WHERE EmailDB = @email";
                SqlCommand cmd = new SqlCommand(sirSQL, con);
                cmd.Parameters.AddWithValue("@email", txtRecuperare.Text);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //con.Close();

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                string email = txtRecuperare.Text;
                Match potrivireEmail = regex.Match(email);
                if (potrivireEmail.Success)
                {
                    if (count == 1)
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        lblNumeUtilizator.Visible = true;
                        lblParola.Visible = true;
                        lblNumeUtilizator.Text = ds.Tables[0].Rows[0][1].ToString();
                        // MessageBox.Show(ds.Tables[0].Rows[0][2].ToString());
                        lblParola.Text = ds.Tables[0].Rows[0][2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Adresa de Email este gresita. Va rugam sa incercati din nou!");
                        txtRecuperare.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Formatul adresei de Email este invalid. Va rugam sa incercati din nou!");
                    txtRecuperare.Text = "";
                }
               
            }
        }
    }
}
