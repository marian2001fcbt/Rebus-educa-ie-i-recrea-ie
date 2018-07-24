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
using System.Configuration;
using System.Text.RegularExpressions;

namespace FormularTaburiDinamice
{
    public partial class frmInregistrare : Form
    {
        char tipUtilizator;
        string sirConectare = System.Configuration.ConfigurationManager.ConnectionStrings["sirConfigurareDB"].ConnectionString;
        //Format expresie verificare email
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
         private void frmInregistrare_Load(object sender, EventArgs e)
        {
            frmInregistrare fi = new frmInregistrare();
            fi.Text = "Inregistrare";
            #region engleza
            if (Auxiliare.Limba == 2)
            {
                label1.Text = "Username";
                label2.Text = "Password";
                label3.Text = "Confirm password";
                label4.Text = "Email adress";
                label5.Text = "User type";
                button1.Text = "Register!";
                button2.Text = "Abort";
            }
            #endregion engleza
        }

        public frmInregistrare()
        {
            InitializeComponent();
            cboTipUtilizator.Text = "Utilizator";
            //cboTipUtilizator.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Verificare campuri utilizatori
            if (txtNumeUtilizator.Text != "" && txtParola.Text != "" && txtReParola.Text != "" && txtEmail.Text != "" && cboTipUtilizator.Text!="")
            {
                #region verificare parola identica
                if (txtParola.Text == txtReParola.Text)
                {
                    #region Verificare email
                    string email = txtEmail.Text;
                    Match potrivireEmail = regex.Match(email);

                    if (potrivireEmail.Success)
                    {
                        if (Auxiliare.UtilizatorLogat == 1)
                        {
                            //Cautare utlilizator existent
                            if (cboTipUtilizator.Text == "Administrator")
                                tipUtilizator = 'A';
                            else
                                tipUtilizator = 'U';


                            #region Sectiounea instructiuni using
                            using (SqlConnection con = new SqlConnection(sirConectare))
                            {

                                string sirSQL2 = "SELECT * FROM Utilizatori WHERE NumeUtilizatorDB = @numeUtilizator";
                                SqlCommand cmd2 = new SqlCommand(sirSQL2, con);
                                cmd2.Parameters.AddWithValue("@numeUtilizator", txtNumeUtilizator.Text);

                                con.Open();

                                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                //con.Close();

                                int count = ds.Tables[0].Rows.Count;
                                //If count is equal to 1, than show frmMain form
                                if (count == 0)
                                {
                                    SqlCommand cmd = new SqlCommand("INSERT INTO Utilizatori(NumeUtilizatorDB, ParolaDB, EmailDB, TipUtilizatorDB) values(@nameUtilizator, @parola, @email, @tipUtilizator)", con);
                                    cmd.Parameters.AddWithValue("@nameUtilizator", txtNumeUtilizator.Text);
                                    cmd.Parameters.AddWithValue("@parola", txtParola.Text);
                                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                                    cmd.Parameters.AddWithValue("@tipUtilizator", tipUtilizator.ToString());

                                    //con.Open();
                                    cmd.ExecuteNonQuery();
                                    if (Auxiliare.Limba == 2)
                                        MessageBox.Show("Registration succeded!");
                                    else
                                        MessageBox.Show("Inregistrarea a fost adaugata cu scucces!");
                                    this.Hide();
                                }
                                else
                                {
                                    if (Auxiliare.Limba == 2)
                                        MessageBox.Show("User already exist!");
                                    else
                                        MessageBox.Show("Utilizatorul deja exista!");
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            if (Auxiliare.Limba == 2)
                                MessageBox.Show("Only an administrator can create an Admin account!");
                            else
                             MessageBox.Show("Numai un administrator poate crea un cont de tip Administrator!");
                            cboTipUtilizator.Focus();
                        }
                    }
                    else
                    {
                        if (Auxiliare.Limba == 2)
                            MessageBox.Show("Incorrect Email adress format!");
                        else
                            MessageBox.Show("Formatul adresei de email incorect!");
                    }
                    #endregion

                    //End using
                }
                else
                {
                    if (Auxiliare.Limba == 2)
                        MessageBox.Show("The Password and Confirm password fields do not match!");
                    else
                    MessageBox.Show("Campurile parola si Repeta parola nu sunt identice!");
                    txtParola.Clear();
                    txtReParola.Clear();
                    txtParola.Focus();
                }
                #endregion
            }
            else
            {
                if (Auxiliare.Limba == 2)
                    MessageBox.Show("The User Name and Password fields must be filled!");
                else
                    MessageBox.Show("Campurile Nume utilizator si Parola sunt obligatorii!");
            }

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auxiliare.UtilizatorLogat = 3;
            this.Close();
        }

       
    }
}
