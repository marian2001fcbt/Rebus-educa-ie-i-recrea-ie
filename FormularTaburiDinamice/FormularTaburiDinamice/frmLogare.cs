using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Adaugate
using System.Data.SqlClient;

namespace FormularTaburiDinamice
{
    public partial class frmLogare : Form
    {
        string sirConectare = System.Configuration.ConfigurationManager.ConnectionStrings["sirConfigurareDB"].ConnectionString;
        public frmLogare()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void lnkInregistrare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmInregistrare fl = new frmInregistrare();
            fl.ShowDialog();
           
        }

        private void frmLogare_Load(object sender, EventArgs e)
        {

        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
                if (txtNumeLogare.Text != "" && txtParolaLogare.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(sirConectare))
                    {
                        string sirSQL = "SELECT * FROM Utilizatori WHERE NumeUtilizatorDB = @numeUtilizator and ParolaDB = @parola";
                        SqlCommand cmd = new SqlCommand(sirSQL, con);
                        cmd.Parameters.AddWithValue("@numeUtilizator", txtNumeLogare.Text);
                        cmd.Parameters.AddWithValue("@parola", txtParolaLogare.Text);
                        con.Open(); 

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        //con.Close();

                        int count = ds.Tables[0].Rows.Count;
                        //If count is equal to 1, than show frmMain form
                        if (count == 1)
                        {
                            if (ds.Tables[0].Rows[0][4].ToString() == "A")
                            {
                                Auxiliare.UtilizatorLogat = 1;
                            }
                            else
                                Auxiliare.UtilizatorLogat = 2;
                            //MessageBox.Show("Nr inregistrari: " + count.ToString() + " utilizator de tip: " + Auxiliare.UtilizatorLogat.ToString());
                        
                            this.Close();
                           // Form1 fa = new Form1();
                            //fa.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Autentificare nereusita. Nume sau parola eronata");
                            txtNumeLogare.Clear();
                            txtParolaLogare.Clear();
                            txtNumeLogare.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campurile Nume utilizator si Parola sunt obligatorii!!!");
                    txtNumeLogare.Focus();
                    txtParolaLogare.Clear();
                }
        }

        private void btnVizitator_Click(object sender, EventArgs e)
        {
            Auxiliare.UtilizatorLogat = 3;
            this.Close();
        }

        private void frmLogare_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
