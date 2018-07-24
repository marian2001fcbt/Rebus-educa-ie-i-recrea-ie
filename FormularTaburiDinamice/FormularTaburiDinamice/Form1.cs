using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
//Adaugate
using System.IO;
using System.Data.SqlClient;

//using FormularTaburiDinamice.CNG;

namespace FormularTaburiDinamice
{
    public partial class Form1 : Form
    {
        public static int utilizatorLogat = 1;
        public int index = 1;
        public string fisierCerinte = Application.StartupPath + "\\Dorinte.txt";
        public int nrLiniiRebus, nrColoaneRebus;
        public int codRebus;
        int i, j, nr, h, m, s, timpTotal;
        int startRand, startColoana;
        string directia;
        int nrRandColoana;
        string cerinta;
        
        List<ClasaIdCelule> cic = new List<ClasaIdCelule>();
        List<ClasaIdCelule> rezolvare = new List<ClasaIdCelule>();
 
        //public string fisierCerinte = Application.StartupPath + "\\CerinteRebus1.txt";
        string sirConectare = System.Configuration.ConfigurationManager.ConnectionStrings["sirConfigurareDB"].ConnectionString;



        public Form1()
        {
           
            InitializeComponent();
            frmLimba flmb = new frmLimba();
            flmb.ShowDialog();
            frmLogare fl = new frmLogare();
            fl.ShowDialog();
            tabPrincipal.Selected += new TabControlEventHandler(tabControl1_Selected);
            PopulareListaRebus();
        }

        private void rezolvareRebusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabPrincipal.TabPages[1].Controls["splitRezolvare"].Visible = true;
            this.tabPrincipal.TabPages[1].Controls["btnSalvare"].Visible = true;
            this.tabPrincipal.TabPages[1].Controls["btnSalvare"].Enabled = true;
            this.tabPrincipal.TabPages[1].Visible = true;
            this.tabPrincipal.TabPages[1].Enabled = true;
            this.tabPrincipal.TabPages[0].Visible = false;
            this.tabPrincipal.TabPages[0].Enabled = false;
            this.tabPrincipal.SelectTab("tabPaginaRezolvare");
            ExtragereCerinteRebusDB();
            //CreareListaCuvinte();//11.05.2016
            InitializareGrilaRebus(nrColoaneRebus, nrLiniiRebus);
            ContorizareTimpRezolvare(); 
        }

        private void progresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabPrincipal.TabPages[0].Visible = false;
            this.tabPrincipal.TabPages[0].Enabled = false;
            this.tabPrincipal.TabPages[1].Visible = false;
            this.tabPrincipal.TabPages[1].Enabled = false;
            this.tabPrincipal.TabPages[1].Controls["splitRezolvare"].Visible = true;
            this.tabPrincipal.SelectTab("tabProgresRebus");
            this.tabPrincipal.TabPages[3].Visible = true;
            this.tabPrincipal.TabPages[3].Enabled = true;

            

        }

        private void adaugareRebusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Auxiliare.UtilizatorLogat == 1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text file |*.txt";
                if (ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    fisierCerinte = ofd.FileName;
                    dgvRebusAdministrare.Rows.Clear();
                    //dgvCerinteOrizontal.Rows.Clear();
                    cic.Clear();
                    IncarcareDateRebus();
                    //CreareListaCuvinte();

                    InitializareGrilaAdministrare(nrColoaneRebus, nrLiniiRebus);

                }

                //tabPrincipal.Controls.Add(tabAdaugareRebus);
                this.tabPrincipal.TabPages[0].Visible = true;
                this.tabPrincipal.TabPages[0].Enabled = true;
                this.tabPrincipal.SelectTab("tabAdaugareRebus");
            }
            else
            {
                if (Auxiliare.Limba == 2)
                    MessageBox.Show("You must be logged in as Administrator to view this page!");
                MessageBox.Show("Trebuie sa fiti logat ca Administrator ca sa putei accesa acesta pagina!");
                this.tabPrincipal.SelectTab("tabPaginaRezolvare");
            }
           
        }

        private void tabAdaugareRebus_Click(object sender, EventArgs e)
        {
            /*if (index != 0)
            {
                this.tabPrincipal.TabPages[0].Visible = true;
                this.tabPrincipal.TabPages[0].Enabled = true;
                this.tabPrincipal.SelectTab("tabAdaugareRebus");
            }
            else
                MessageBox.Show("Trebuie sa fiti logat ca Administrator ca sa putei accesa acesta pagina!!!!");*/
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == tabAdaugareRebus.Name)
                if (Auxiliare.UtilizatorLogat==1)
                {
                    this.tabPrincipal.TabPages[0].Visible = true;
                    this.tabPrincipal.TabPages[0].Enabled = true;
                    this.tabPrincipal.SelectTab("tabAdaugareRebus");
                }
                else
                {
                    MessageBox.Show("Trebuie sa fiti logat ca Administrator ca sa putei accesa acesta pagina!!!!");
                    this.tabPrincipal.SelectTab("tabPaginaRezolvare");
                }
        }
        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (tabPrincipal.SelectedTab == tabPrincipal.TabPages["tabAdaugareRebus"] && index != 0)
            {

                this.tabPrincipal.TabPages[0].Visible = true;
                this.tabPrincipal.TabPages[0].Enabled = true;
                this.tabPrincipal.SelectTab("tabAdaugareRebus");
            }
            else
            {
               
                MessageBox.Show("Trebuie sa fiti logat ca Administrator ca sa putei accesa acesta pagina!!!!");
                this.tabPrincipal.SelectTab("tabPaginaRezolvare");
            }*/
        }


        #region Componenta Administrare

        private void ddlRebusAdministrare_SelectedIndexChanged(object sender, EventArgs e)
        {
            cic.Clear();
            rezolvare.Clear();
            // MessageBox.Show("Index selectat: " + selectedIndex.ToString() + " valoare selectata:  " + selectedValue.ToString());

            using (SqlConnection con = new SqlConnection(sirConectare))
            {

                string sirSQL2 = "SELECT * FROM Rebuse WHERE IdRebusDB = +'" + ddlRebusAdministrare.SelectedValue + "'";
                SqlCommand cmd2 = new SqlCommand(sirSQL2, con);
                //cmd2.Parameters.AddWithValue("@idRebus", Convert.ToInt32(ddlRebus.SelectedValue.ToString()));

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                codRebus = Convert.ToInt32(dt.Rows[0]["IdRebusDB"].ToString());
                nrColoaneRebus = Convert.ToInt32(dt.Rows[0]["NrColoaneDB"].ToString());
                nrLiniiRebus = Convert.ToInt32(dt.Rows[0]["NrLiniiDB"].ToString());


                //MessageBox.Show("Id rebus: " + ddlRebusAdministrare.SelectedValue.ToString() + " " + nrColoaneRebus.ToString() + " " + nrLiniiRebus.ToString());
                //MessageBox.Show("Id rebus: " + codRebus.ToString() + " " + nrColoaneRebus.ToString() + " " + nrLiniiRebus.ToString());
                //Adaugate 12.05.2015
                ExtragereCerinteRebusDB();
                //CreareListaCuvinte();//11.05.2016
                InitializareGrilaAdministrare(nrColoaneRebus, nrLiniiRebus);
                //ContorizareTimpRezolvare();
            }
            //PopulareListaRebus();

            //CreareListaCuvinte();
            //InitializareGrilaRebus(nrColoaneRebus, nrLiniiRebus);
            //ContorizareTimpRezolvare(); 
        }


        private void IncarcareDateRebus()
        {
            
            int k = 0;
            String linie = "";
            using (StreamReader sr = new StreamReader(fisierCerinte))
            {
                //ignara prima linie
                linie = sr.ReadLine();
                String[] antet = linie.Split('|');
                codRebus = Convert.ToInt32(antet[0].ToString());
                nrLiniiRebus = Convert.ToInt32(antet[2].ToString());
                nrColoaneRebus = Convert.ToInt32(antet[3].ToString());
                //MessageBox.Show("Antet: " + antet[0].ToString() + " " + antet[1].ToString() + " " + antet[2].ToString() + " " + antet[3].ToString() + " " + antet[4].ToString());
                
                //*********************************8
                //Cautare utlilizator existent

                #region Sectiounea instructiuni using
                using (SqlConnection con = new SqlConnection(sirConectare))
                {

                    string sirSQL2 = "SELECT * FROM Rebuse WHERE IdRebusDB = @idRebus";
                    SqlCommand cmd2 = new SqlCommand(sirSQL2, con);
                    cmd2.Parameters.AddWithValue("@idRebus", Convert.ToInt32(antet[0].ToString()));

                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    //con.Close();

                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    if (count == 0)
                    {
                        SqlCommand cmd3 = new SqlCommand("INSERT INTO  Rebuse (IdRebusDB, TitluRebusDB, NrLiniiDB, NrColoaneDB, TimpRezolvareDB) VALUES(@indiceRebus, @titluRebus, @nrLiniiRebus, @nrColoaneRebus, @timpRezolvareRebus)", con);
                        cmd3.Parameters.AddWithValue("@indiceRebus", Convert.ToInt32(antet[0].ToString()));
                        cmd3.Parameters.AddWithValue("@titluRebus", antet[1].ToString());
                        cmd3.Parameters.AddWithValue("@nrLiniiRebus", Convert.ToInt32(antet[2].ToString()));
                        cmd3.Parameters.AddWithValue("@nrColoaneRebus", Convert.ToInt32(antet[3].ToString()));
                        cmd3.Parameters.AddWithValue("@timpRezolvareRebus", Convert.ToInt32(antet[4].ToString()));

                        cmd3.ExecuteNonQuery();
                        //***************************************************

                        while ((linie = sr.ReadLine()) != null)
                        {
                            k++;
                            String[] coloane = linie.Split('|');
                            // MessageBox.Show(coloane[2].ToString() + "  " + coloane[2].ToString() + "  " +
                            //     coloane[3].ToString() + "  " + coloane[4].ToString() + "  " + coloane[5].ToString() + "  " + coloane[6].ToString());

                            //using (SqlConnection con = new SqlConnection(sirConectare))
                            //{

                                SqlCommand cmd = new SqlCommand("INSERT INTO  Cerinte (IdRebusDB, IdCerintaDB, PozitiaXDB, PozitiaYDB, DirectiaDB, NrLinieColoana, CuvantDB, TextCerintaDB)  VALUES ( @idRebus, @idCerinta, @pozitiaX, @pozitiaY, @directia, @nrLinieColoana, @cuvant, @textCerinta )", con);

                                cmd.Parameters.AddWithValue("idRebus", Convert.ToInt32(codRebus.ToString()));
                                cmd.Parameters.AddWithValue("@idCerinta", Convert.ToInt32(k.ToString()));

                                cmd.Parameters.AddWithValue("@pozitiaX", Convert.ToInt32(coloane[0].ToString()));
                                cmd.Parameters.AddWithValue("@pozitiaY", Convert.ToInt32(coloane[1].ToString()));
                                cmd.Parameters.AddWithValue("@directia", coloane[2].ToString());
                                cmd.Parameters.AddWithValue("@nrLinieColoana", Convert.ToInt32(coloane[3].ToString()));
                                cmd.Parameters.AddWithValue("@cuvant", coloane[4].ToString());
                                cmd.Parameters.AddWithValue("@textCerinta", coloane[5].ToString());

                                //con.Open();

                                cmd.ExecuteNonQuery();
                           // }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rebusul este deja adaugat in baza de date!");
                    }
                }

                #endregion Sectiounea instructiuni using
            }
        }
        private void InitializareGrilaAdministrare(int x, int y)
        {
            dgvRebusAdministrare.Rows.Clear();
            dgvRebusAdministrare.Refresh();
            dgvRebusAdministrare.ColumnCount = nrColoaneRebus;

            for (int i = 0; i < y; i++)
            {
                DataGridViewRow linie = new DataGridViewRow();
                for (int j = 0; j < x; j++)
                {
                    //Culoare de fundal si culoarea de selectie - ambelele la negru
                    dgvRebusAdministrare.Columns[j].DefaultCellStyle.BackColor = Color.Black;
                    //dgvRebus.Columns[j].DefaultCellStyle.ForeColor = Color.Blue;
                    dgvRebusAdministrare.Columns[j].DefaultCellStyle.SelectionBackColor = Color.Black;
                    //Tipul si marimea fontului de editare
                    //dgvRebusAdministrare.Columns[j].DefaultCellStyle.Font = new Font("Tahoma", 15);
                }
               
                dgvRebusAdministrare.Rows.Add();

            }

            //Stabilirea latimii, respectiv inaltimii celulelor
            foreach (DataGridViewColumn c in dgvRebusAdministrare.Columns)
            {
                c.Width = dgvRebusAdministrare.Width / nrColoaneRebus;
            }

            foreach (DataGridViewRow r in dgvRebusAdministrare.Rows)
            {
                r.Height = dgvRebusAdministrare.Height / nrLiniiRebus;
            }

            //Setarea proprietatii celulelor cu valoarea ReadOnly
            for (i = 0; i < dgvRebusAdministrare.Rows.Count; i++)
            {
                for (j = 0; j < dgvRebusAdministrare.Columns.Count; j++)
                {
                    dgvRebusAdministrare[j, i].ReadOnly = true;
                    dgvRebusAdministrare[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
            }
            //Interzice redimensionarea atat pe linii cat si pe coloane
            dgvRebusAdministrare.AllowUserToResizeColumns = false;
            dgvRebusAdministrare.AllowUserToResizeRows = false;
            dgvRebusAdministrare.BorderStyle = BorderStyle.Fixed3D;

            foreach (ClasaIdCelule i in cic)
            {
                startColoana = i.X;
                startRand = i.Y;
                directia = i.directia;
                nrRandColoana = i.numarul;
                cerinta = i.cerinta;

                char[] cuvant = i.cuvant.ToCharArray();
                for (j = 0; j < cuvant.Length; j++)
                {
                    if (i.directia.ToUpper() == "ORIZONTAL")
                    {
                        //MessageBox.Show("Randul:" + i.Y.ToString() + " colana: " +i.X.ToString() );
                        FormatareCelulaAdministrare(startRand - 1, (startColoana - 1) + j, cuvant[j].ToString());
                    }
                    if (i.directia.ToUpper() == "VERTICAL")
                    {
                        //MessageBox.Show("Randul:" + i.Y.ToString() + " colana: " + i.X.ToString());
                        FormatareCelulaAdministrare((startRand - 1) + j, (startColoana - 1), cuvant[j].ToString());
                    }
                }
            }
        }

        public void FormatareCelulaAdministrare(int linia, int coloana, String litera)
        {
            DataGridViewCell celula = dgvRebusAdministrare[coloana, linia];
            celula.Style.BackColor = Color.White;
            celula.ReadOnly = false;
            celula.Style.SelectionBackColor = Color.Cyan;

            celula.Tag = litera;
            //MessageBox.Show("Tag = " + celula.Tag);
            //Afisare litere in celule
            celula.Value = litera.ToString(); //- 30.04.2016
        }

        private void dgvRebusAdministrare_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                //Verifica daca numarul de caractere introduse este mai mare decat 1
                // daca, DA, le reduce la primul carcter introdus
                if (e.ToString().Length > 1)
                {
                    e.Value = e.Value.ToString().Substring(0, 1);
                }
                //verifica daca acel cracter introdus este identic cu cel corect
                //daca DA, este afisat cu culoare albastra si ingrosat
                //daca NU este afisat cu culoare rosie
                if (dgvRebusAdministrare[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(dgvRebusAdministrare[e.ColumnIndex, e.RowIndex].Tag.ToString()))
                {
                    dgvRebusAdministrare[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dgvRebusAdministrare[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
                }
                //Converteste caracteru la litera mare
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void PopulareListaRebus()
        {
            using (SqlConnection con = new SqlConnection(sirConectare))
            {
                string sirSQL2 = "SELECT * FROM Rebuse";
                SqlCommand cmd2 = new SqlCommand(sirSQL2, con);
                //cmd2.Parameters.AddWithValue("@idRebus", Convert.ToInt32(antet[0].ToString()));

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlRebus.DisplayMember = "TitluRebusDB";
                ddlRebus.ValueMember = "IdRebusDB";
                ddlRebus.DataSource = dt;
                
                //ddlRebus.SelectedIndex = 0;
                //nrColoaneRebus = Convert.ToInt32(dt.Rows[Convert.ToInt32(ddlRebus.SelectedIndex.ToString())]["NrColoaneDB"].ToString());
                //nrLiniiRebus = Convert.ToInt32(dt.Rows[Convert.ToInt32(ddlRebus.SelectedIndex.ToString())]["NrLiniiDB"].ToString());
                //MessageBox.Show("Prima coloane este: " + ddlRebus.SelectedValue.ToString() + " " + nrColoaneRebus.ToString() + " " + nrLiniiRebus.ToString());

                ddlRebusAdministrare.DisplayMember = "TitluRebusDB";
                ddlRebusAdministrare.ValueMember = "IdRebusDB";
                ddlRebusAdministrare.DataSource = dt;
               
               
                //ddlRebusAdministrare.SelectedIndex = 0;
            }
        }
        #endregion Componenta Administrare

        #region Componenta client
        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
            }

            txtOreRamase.Text = Convert.ToString(h);
            txtMinuteRamase.Text = Convert.ToString(m);
            txtSecundeRamase.Text = Convert.ToString(s);
        }
        
        public void InitializareGrilaRebus(int x, int y)
        {
            //MessageBox.Show("Initializare grila: x= " + x.ToString() + " y = " + y.ToString() + " nr coloane rebus " + nrColoaneRebus.ToString());
            //dgvRebus = new DataGridView();
            dgvRebus.Rows.Clear();
            dgvRebus.Refresh();
            dgvRebus.ColumnCount = nrColoaneRebus; //11.05.2016 - trebuie obligatoriu

            ////DataGridView dgvGrila = new DataGridView();
            ///dgvGrila = dgvRebus;

            //dgvRebus.Size =  new Size(nrLiniiRebus*20, nrColoaneRebus * 20);
            for (int i = 0; i < y; i++)
            {
                DataGridViewRow linie = new DataGridViewRow();
                for (int j = 0; j < x; j++)
                {
                    //Culoare de fundal si culoarea de selectie - ambelele la negru
                    dgvRebus.Columns[j].DefaultCellStyle.BackColor = Color.Black;
                    //dgvRebus.Columns[j].DefaultCellStyle.ForeColor = Color.Blue;
                    dgvRebus.Columns[j].DefaultCellStyle.SelectionBackColor = Color.Black;
                    //Tipul si m[rimea fontului de editare
                    //dgvRebus.Columns[j].DefaultCellStyle.Font = new Font("Tahoma", 15);

                    //dgvRebus.Rows.Height = nrLiniiRebus*30;
                }
                
                dgvRebus.Rows.Add();

            }

            //Stabilirea latimii, respectiv inaltimii celulelor
            foreach (DataGridViewColumn c in dgvRebus.Columns)
            {
                c.Width = dgvRebus.Width / nrColoaneRebus;
            }

            foreach (DataGridViewRow r in dgvRebus.Rows)
            {
                r.Height = dgvRebus.Height / nrLiniiRebus;
            }

            //Setarea proprietatii celulelor cu valoarea ReadOnly
            for (i = 0; i < dgvRebus.Rows.Count; i++)
            {
                for (j = 0; j < dgvRebus.Columns.Count; j++)
                {
                    dgvRebus[j, i].ReadOnly = true;
                    dgvRebus[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
            }
            //Interzice redimensionarea atat pe linii cat si pe coloane
            dgvRebus.AllowUserToResizeColumns = false;
            dgvRebus.AllowUserToResizeRows = false;
            dgvRebus.BorderStyle = BorderStyle.Fixed3D;

            foreach (ClasaIdCelule i in cic)
            {
                startColoana = i.X;
                startRand = i.Y;
                directia = i.directia;
                nrRandColoana = i.numarul;
                cerinta = i.cerinta;

                char[] cuvant = i.cuvant.ToCharArray();
                for (j = 0; j < cuvant.Length; j++)
                {
                    if (i.directia.ToUpper() == "ORIZONTAL")
                    {
                        //MessageBox.Show("Randul:" + i.Y.ToString() + " colana: " +i.X.ToString() );
                        FormatareCelula(startRand - 1, (startColoana - 1) + j, cuvant[j].ToString());
                    }
                    if (i.directia.ToUpper() == "VERTICAL")
                    {
                        //MessageBox.Show("Randul:" + i.Y.ToString() + " colana: " + i.X.ToString());
                        FormatareCelula((startRand - 1) + j, (startColoana - 1), cuvant[j].ToString());
                    }
                }
            }
        }

        public void ContorizareTimpRezolvare()
        {
            h = timpTotal / 3600;
            m = (timpTotal % 3600) / 60;
            s = (timpTotal % 3600) % 60;
            txtOreEstimat.Text = h.ToString();
            txtMinuteEstimate.Text = m.ToString();
            txtSecundeEstimate.Text = s.ToString();

            txtOreRamase.Text = h.ToString();
            txtMinuteRamase.Text = m.ToString();
            txtSecundeRamase.Text = s.ToString();

            timer1.Start();
        }

        public void CreareListaCuvinte()
        {
            DataGridViewRow gr = new DataGridViewRow();
            String linie = "";
            using (StreamReader sr = new StreamReader(fisierCerinte))
            {
                //ignara prima linie
                linie = sr.ReadLine();
                while ((linie = sr.ReadLine()) != null)
                {
                    String[] l = linie.Split('|');
                   // MessageBox.Show("Linie:" + Int32.Parse(l[0]).ToString() + " " + Int32.Parse(l[1]).ToString() + " " + l[2].ToString() + " " + Int32.Parse(l[3]).ToString() + " " + l[4].ToString() + " " + l[5].ToString());
                    cic.Add(new ClasaIdCelule(Int32.Parse(l[0]), Int32.Parse(l[1]), l[2], Int32.Parse(l[3]), l[4], l[5]));

                    //Adaugat  - 29.04.2016
                    rezolvare.Add(new ClasaIdCelule(Int32.Parse(l[0]), Int32.Parse(l[1]), l[2], Int32.Parse(l[3]), "", l[5]));
                    if (l[2].ToString() == "orizontal")
                    {
                        dgvCerinteOrizontal.Rows.Add(l[3], l[5]);
                    }
                    else
                    {
                        dgvCerinteVertical.Rows.Add(l[3], l[5]);
                    }
                    //dgvCerinteOrizontal.Rows.Add(l[3], l[2], l[5]);
                    dgvCerinteAdministrare.Rows.Add(l[3], l[2], l[5]);
                   
                }
            }
            //Copie a listei originale - 29.04.2016
            //rezolvare = cic;
        }


        public void FormatareCelula(int linia, int coloana, String litera)
        {
            DataGridViewCell celula = dgvRebus[coloana, linia];
            celula.Style.BackColor = Color.White;
            celula.ReadOnly = false;
            celula.Style.SelectionBackColor = Color.Cyan;

            celula.Tag = litera;
            //MessageBox.Show("Tag = " + celula.Tag);
            //Afisare litere in celule
            //celula.Value = litera.ToString(); //- 30.04.2016
        }

        private void dgvRebus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                //Verifica daca numarul de caractere introduse este mai mare decat 1
                // daca, DA, le reduce la primul carcter introdus
                if (e.ToString().Length > 1)
                {
                    e.Value = e.Value.ToString().Substring(0, 1);
                }
                //verifica daca acel cracter introdus este identic cu cel corect
                //daca DA, este afisat cu culoare albastra si ingrosat
                //daca NU este afisat cu culoare rosie
                if (dgvRebus[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(dgvRebus[e.ColumnIndex, e.RowIndex].Tag.ToString()))
                {
                    dgvRebus[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dgvRebus[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
                }
                //Converteste caracteru la litera mare
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void ddlRebus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //12.05.2016
            cic.Clear();
            rezolvare.Clear();
            // MessageBox.Show("Index selectat: " + selectedIndex.ToString() + " valoare selectata:  " + selectedValue.ToString());
            //dgvRebus.Dispose();
            using (SqlConnection con = new SqlConnection(sirConectare))
            {

                string sirSQL2 = "SELECT * FROM Rebuse WHERE IdRebusDB = '" + ddlRebus.SelectedValue + "'";
                SqlCommand cmd2 = new SqlCommand(sirSQL2, con);
                //cmd2.Parameters.AddWithValue("@idRebus", Convert.ToInt32(ddlRebus.SelectedValue.ToString()));

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                timpTotal = Convert.ToInt32(dt.Rows[0]["TimpRezolvareDB"].ToString());
                codRebus = Convert.ToInt32(dt.Rows[0]["IdRebusDB"].ToString());
                nrColoaneRebus = Convert.ToInt32(dt.Rows[0]["NrColoaneDB"].ToString());
                nrLiniiRebus = Convert.ToInt32(dt.Rows[0]["NrLiniiDB"].ToString());


                //MessageBox.Show("Id rebus: " + codRebus.ToString() + " timp rezolvare:  " + timpTotal.ToString() + " " + nrColoaneRebus.ToString() + " " + nrLiniiRebus.ToString());
                //Adaugate 12.05.2015
                ExtragereCerinteRebusDB();
                //CreareListaCuvinte();//11.05.2016
                InitializareGrilaRebus(nrColoaneRebus, nrLiniiRebus);
                ContorizareTimpRezolvare(); 

            }

            //CreareListaCuvinte();
            //InitializareGrilaRebus(nrColoaneRebus, nrLiniiRebus);
            //ContorizareTimpRezolvare();
        }

        #endregion Componenta Client

        private void inregistrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInregistrare fi = new frmInregistrare();
            fi.ShowDialog();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Auxiliare.Limba == 2)
            {
                administrareToolStripMenuItem.Text = "Administration";
                logareToolStripMenuItem.Text = "Log in";
                inregistrareToolStripMenuItem.Text = "Register new member";
                adaugareRebusToolStripMenuItem.Text = "Add new crossword";
                recuperareContToolStripMenuItem.Text = "Recover account data";
                rebusToolStripMenuItem.Text = "Crossword";
                selectareRebusToolStripMenuItem.Text = "Select crossword";
                tiparireToolStripMenuItem.Text = "Print crossword";
                iesireToolStripMenuItem1.Text = "Exit";
                delogareToolStripMenuItem.Text = "Log off";
                iesireDinAplicatieToolStripMenuItem.Text = "Exit from application";
                ajutorToolStripMenuItem.Text = "Help";
                despreToolStripMenuItem.Text = "About";
                label1.Text = "Select crossword:";
                label2.Text = "Select crossword:";
                label9.Text = "Horizontal";
                label10.Text = "Vertical";
                label3.Text = "Estimated time";
                label4.Text = "Remaining time";
                btnSalvare.Text = "Save";
                tabAdaugareRebus.Text = "View crossword";
                tabPaginaRezolvare.Text = "Resolve crossword";

            }
            if (Auxiliare.UtilizatorLogat == 1)
            {
                this.tabPrincipal.TabPages[0].Visible = true;
                this.tabPrincipal.TabPages[0].Enabled = true;
                this.tabPrincipal.SelectTab("tabAdaugareRebus");

                this.tabPrincipal.TabPages[1].Controls["splitRezolvare"].Visible = false;
                this.tabPrincipal.TabPages[1].Visible = false;
                this.tabPrincipal.TabPages[1].Enabled = false;
                //ExtragereCerinteRebusDB();
                //InitializareGrilaAdministrare(nrColoaneRebus, nrLiniiRebus);
                //ddlRebusAdministrare.SelectedIndex = 0;
            }
            else
            {
                if (Auxiliare.UtilizatorLogat == 2)
                {
                    //MessageBox.Show("Dupa apasarea butonului OK se afiseaza continutul!!!!");
                    this.tabPrincipal.TabPages[1].Controls["splitRezolvare"].Visible = true;
                    this.tabPrincipal.TabPages[1].Controls["btnSalvare"].Visible = true;
                    this.tabPrincipal.TabPages[1].Controls["btnSalvare"].Enabled = true;
                    this.tabPrincipal.TabPages[1].Visible = true;
                    this.tabPrincipal.TabPages[1].Enabled = true;
                    this.tabPrincipal.TabPages[0].Visible = false;
                    this.tabPrincipal.TabPages[0].Enabled = false;
                    this.tabPrincipal.SelectTab("tabPaginaRezolvare");
                }
                if (Auxiliare.UtilizatorLogat == 3)
                {
                    //MessageBox.Show("Dupa apasarea butonului OK se afiseaza continutul!!!!");
                    this.tabPrincipal.TabPages[1].Controls["splitRezolvare"].Visible = true;
                    this.tabPrincipal.TabPages[1].Controls["btnSalvare"].Visible = true;
                    this.tabPrincipal.TabPages[1].Controls["btnSalvare"].Enabled = false;
                    this.tabPrincipal.TabPages[1].Visible = true;
                    this.tabPrincipal.TabPages[1].Enabled = true;
                    this.tabPrincipal.TabPages[0].Visible = false;
                    this.tabPrincipal.TabPages[0].Enabled = false;
                    this.tabPrincipal.SelectTab("tabPaginaRezolvare");
                }

                //ExtragereCerinteRebusDB();
                //CreareListaCuvinte();//11.05.2016
                //InitializareGrilaRebus(nrColoaneRebus, nrLiniiRebus);
                //ContorizareTimpRezolvare(); 

                //ddlRebus.SelectedIndex = 0;
            }
            // TODO: This line of code loads data into the 'rebusDataSet.Rebuse' table. You can move, or remove it, as needed.
            //this.rebuseTableAdapter.Fill(this.rebusDataSet.Rebuse);
           // ddlRebusAdministrare.SelectedIndex = 0;
            //ddlRebus.SelectedIndex = 0;
            //codRebus = ddlRebusAdministrare.SelectedValue;

            using (SqlConnection con = new SqlConnection(sirConectare))
            {

                string sirSQL2 = "SELECT * FROM Rebuse WHERE IdRebusDB = '" + ddlRebus.SelectedValue + "'";
                SqlCommand cmd2 = new SqlCommand(sirSQL2, con);
                //cmd2.Parameters.AddWithValue("@idRebus", Convert.ToInt32(ddlRebus.SelectedValue.ToString()));

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //11.05.2016 orele 15:45
               // nrColoaneRebus = Convert.ToInt32(dt.Rows[0]["NrColoaneDB"].ToString());
                //nrLiniiRebus = Convert.ToInt32(dt.Rows[0]["NrLiniiDB"].ToString());
                //MessageBox.Show("Id rebus: " + ddlRebus.SelectedValue.ToString() + " " + nrColoaneRebus.ToString() + " " + nrLiniiRebus.ToString());
                //ExtragereCerinteRebusDB();

                //InitializareGrilaAdministrare(nrColoaneRebus, nrLiniiRebus);
                //InitializareGrilaRebus(nrColoaneRebus, nrLiniiRebus);
                //ContorizareTimpRezolvare(); 
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ExtragereCerinteRebusDB()
        {
           
            int idRebus = codRebus;
           //int idRebus = 1;
            cic.Clear();
            rezolvare.Clear();
            dgvCerinteOrizontal.Rows.Clear();
            dgvCerinteVertical.Rows.Clear();
            dgvCerinteAdministrare.Rows.Clear();
            using (SqlConnection con = new SqlConnection(sirConectare))
            {
                string sirSQL = "SELECT * FROM Cerinte WHERE IdRebusDB = @idRebus";
               
                SqlCommand cmd = new SqlCommand(sirSQL, con);
                cmd.Parameters.AddWithValue("@idRebus", idRebus);
               
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cic.Add(new ClasaIdCelule(Int32.Parse(dr[2].ToString()), Int32.Parse(dr[3].ToString()), dr[4].ToString(), Int32.Parse(dr[5].ToString()), dr[6].ToString(), dr[7].ToString()));
                    // MessageBox.Show("Linie:" + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString() + " " + dr[5].ToString() + " " + dr[6].ToString() + " " + dr[7].ToString());
                     rezolvare.Add(new ClasaIdCelule(Int32.Parse(dr[2].ToString()), Int32.Parse(dr[3].ToString()), dr[4].ToString(), Int32.Parse(dr[5].ToString()), dr[6].ToString(), dr[7].ToString()));
                     if (dr[4].ToString() == "orizontal")
                     {
                         dgvCerinteOrizontal.Rows.Add(dr[5], dr[7]);
                     }
                     if (dr[4].ToString() == "vertical")
                     {
                         dgvCerinteVertical.Rows.Add(dr[5], dr[7]);
                     }
                     //dgvCerinteOrizontal.Rows.Add(l[3], l[2], l[5]);
                     dgvCerinteAdministrare.Rows.Add(dr[5], dr[4], dr[7]);

                }

               
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

                 //Afisare continut lista rezolvare
            rezolvare.Clear();
            foreach(ClasaIdCelule i in cic)
            {
                startColoana = i.X;
                startRand = i.Y;
                directia = i.directia;
                nrRandColoana = i.numarul;
                cerinta = i.cerinta;
                
                
               char [] cuvantPrelucrare = i.cuvant.ToCharArray();
               
               //MessageBox.Show("Lungime cuvant: " + cuvantPrelucrare.Length); 

               char [] cuvantRezolvat = new char[cuvantPrelucrare.Length];
                   if (i.directia.ToUpper() == "ORIZONTAL")
                   {
                       for (j = 0; j < cuvantPrelucrare.Length; j++)
                       {
                           //Preia din celula valoarea memorata
                           //cuvantRezolvat[j] = Convert.ToChar((dgvRebus[(startColoana - 1) + j, startRand - 1].Tag.ToString()));
                           //Preia din celula valoarea afisata - odificata de utilizator
                           if (dgvRebus[(startColoana - 1) + j, startRand - 1].Value!=null)
                                cuvantRezolvat[j] = Convert.ToChar((dgvRebus[(startColoana - 1) + j, startRand - 1].Value.ToString()));
                       //MessageBox.Show("Randul:" + i.Y.ToString() + " colana: " + i.X.ToString() + "  " + cuvantRezolvat[j].ToString());
                       }
                   }
                   if (i.directia.ToUpper() == "VERTICAL")
                   {
                       for (j = 0; j < cuvantPrelucrare.Length; j++)
                       {
                           //Preia din celula valoarea memorata
                           //cuvantRezolvat[j] = Convert.ToChar(dgvRebus[startColoana - 1, (startRand - 1) + j].Tag.ToString());
                           //Preia din celula valoarea afisata - odificata de utilizator
                           if (dgvRebus[startColoana - 1, (startRand - 1) + j].Value!=null)
                                cuvantRezolvat[j] = Convert.ToChar(dgvRebus[startColoana - 1, (startRand - 1) + j].Value.ToString());
                           //MessageBox.Show("Randul:" + i.Y.ToString() + " colana: " + i.X.ToString() + "  " + cuvantRezolvat[j].ToString()); 
                       }
                   }




               string sir = new string(cuvantRezolvat);
                if(sir.Length!=0)
                {
                    MessageBox.Show("cuvant: " + Convert.ToString(sir));
                    rezolvare.Add(new ClasaIdCelule(Convert.ToInt32(startColoana), Convert.ToInt32(startRand), directia.ToString(), Convert.ToInt32(nrRandColoana), sir.ToString(), cerinta.ToString()));
                    //MessageBox.Show("Cuvantul rezolvat: " + Convert.ToString(rezolvare.ToString()));
                }
            }

            foreach (ClasaIdCelule k in rezolvare)
            {
               MessageBox.Show("X = " + k.X.ToString() + " Y = " + k.Y.ToString() + " Directia = " + k.directia.ToString() + " Nr = " + k.numarul.ToString() + " Cuvant = " + k.cuvant.ToString() + " Cerinta = " + k.cerinta.ToString());
              
                MessageBox.Show("Nr litere cuvant: " + k.cuvant.Length.ToString());
            }




            //ExtragereCerinteRebusDB();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogare fl = new frmLogare();
            fl.ShowDialog();
        }
       
        //Extrage id-ul rebusului, numarul de linii, coloane, timpul de executie din tabela Rebuse
        public void InitialiazareDatePrimare()
        {
            cic.Clear();
            rezolvare.Clear();
            dgvCerinteOrizontal.Rows.Clear();
            dgvCerinteVertical.Rows.Clear();
            dgvCerinteAdministrare.Rows.Clear();
            using (SqlConnection con = new SqlConnection(sirConectare))
            {
                string sirSQL = "SELECT * FROM Rebus";

                SqlCommand cmd = new SqlCommand(sirSQL, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cic.Add(new ClasaIdCelule(Int32.Parse(dr[2].ToString()), Int32.Parse(dr[3].ToString()), dr[4].ToString(), Int32.Parse(dr[5].ToString()), dr[6].ToString(), dr[7].ToString()));
                    // MessageBox.Show("Linie:" + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString() + " " + dr[5].ToString() + " " + dr[6].ToString() + " " + dr[7].ToString());
                    rezolvare.Add(new ClasaIdCelule(Int32.Parse(dr[2].ToString()), Int32.Parse(dr[3].ToString()), dr[4].ToString(), Int32.Parse(dr[5].ToString()), dr[6].ToString(), dr[7].ToString()));
                    if (dr[4].ToString() == "orizontal")
                    {
                        dgvCerinteOrizontal.Rows.Add(dr[5], dr[7]);
                    }
                }
            }
        }

        private void tiparireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int width = 0;
            int height = 0;
            int x = 0;
            int y = 0;
            int rowheight = 0;
            int columnwidth = 0;

            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            Pen p = new Pen(Color.Black, 2.5f);
            
            //Tiparire grilei rebus - la jumatatea paginii
            Bitmap bm = new Bitmap(this.dgvRebus.Width, this.dgvRebus.Height);
            dgvRebus.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvRebus.Width, this.dgvRebus.Height));
            dgvRebus.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvRebus.Width, this.dgvRebus.Height));
            e.Graphics.DrawImage(bm, this.dgvRebus.Width/2, 30);
            
            //Tiparire continut cerinte
           
            /*
            width = 100 + dgvCerinteAdministrare.Columns[0].Width;
            height = 100;
            //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
            while (i < dgvCerinteAdministrare.Rows.Count - 1)
            {
                if (height > e.MarginBounds.Height)
                {
                    height = 100;
                    width = 100;
                    e.HasMorePages = true;
                    return;
                }

                height += dgvCerinteAdministrare.Rows[i].Height;
                e.Graphics.DrawRectangle(Pens.Black, 100, height, dgvCerinteAdministrare.Columns[0].Width, dgvCerinteAdministrare.Rows[0].Height);
                e.Graphics.DrawString(dgvCerinteAdministrare.Rows[i].Cells[0].FormattedValue.ToString(), dgvCerinteAdministrare.Font, Brushes.Black, new RectangleF(100, height, dgvCerinteAdministrare.Columns[0].Width, dgvCerinteAdministrare.Rows[0].Height), str);

                e.Graphics.DrawRectangle(Pens.Black, 100 + dgvCerinteOrizontal.Columns[0].Width, height, dgvCerinteOrizontal.Columns[0].Width, dgvCerinteOrizontal.Rows[0].Height);
                e.Graphics.DrawString(dgvCerinteAdministrare.Rows[i].Cells[1].Value.ToString(), dgvCerinteAdministrare.Font, Brushes.Black, new RectangleF(100 + dgvCerinteAdministrare.Columns[0].Width, height, dgvCerinteAdministrare.Columns[0].Width, dgvCerinteAdministrare.Rows[0].Height), str);

                width += dgvCerinteAdministrare.Columns[0].Width;
                i++;
            }
            */

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            string numeRebus = ddlRebus.Text;
            int startY = 65;
           //int startY = ddlRebus.Height + 20;
            //int Offset = 40;
            int Offset = dgvRebus.Height + 20;
            //MessageBox.Show("Masura inaltime rebus: " + Offset.ToString() + "   " + numeRebus.ToString());
            graphics.DrawString(numeRebus, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            string underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 15;
            int a = dgvCerinteAdministrare.Rows.Count - 1;
            for (int i = 0; i < a; i++)
            {
                /*if (Offset > e.MarginBounds.Height)
                {
                    Offset = 40;
                    e.HasMorePages = true;
                    return;
                }*/
                
                graphics.DrawString(Convert.ToString(dgvCerinteAdministrare.Rows[i].Cells[0].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                graphics.DrawString("\t" + Convert.ToString(dgvCerinteAdministrare.Rows[i].Cells[1].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                graphics.DrawString("\t\t\t\t" + Convert.ToString(dgvCerinteAdministrare.Rows[i].Cells[2].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 15;
            }

        }

        private void dgvRebusAdministrare_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           /* for (int j = 0; j < dgvRebusAdministrare.Columns.Count; j++)
            {
                if (e.RowIndex == 0 && e.ColumnIndex == j)
                {
                    //Rectangle r = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                    Rectangle r = new Rectangle(e.CellBounds.X, e.CellBounds.Y, 8, 8);
                    e.Graphics.FillRectangle(Brushes.White, r);
                    Font f = new Font(e.CellStyle.Font.FontFamily, 7);
                    e.Graphics.DrawString((j+1).ToString(), f, Brushes.Black, r);
                    e.PaintContent(e.ClipBounds);
                    e.Handled = true;
                }
            }*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iesireDinAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void delogareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogare flg = new frmLogare();
            flg.Show();
        }

        private void recuperareContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Auxiliare.UtilizatorLogat == 1)
            {
                frmRecuperare rec = new frmRecuperare();
                rec.Show();
            }
            else
                if (Auxiliare.Limba == 2)
                    MessageBox.Show("You must be logged in as Administrator in order to recover informations about your account. Please ask an administrator to recover your informations.");
                else
                    MessageBox.Show("Trebuie sa fiti logat ca Administrator ca sa puteti recupera informatiile despre contul dvs. Va rugam sa va adresati unui administrator.");
            
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "file://d:\\FormularTaburiDinamice\\FormularTaburiDinamice\\FormularTaburiDinamice\\Resurse\\Ajutor\\ajutor.chm");

        }

        
    }

    public class ClasaIdCelule
    {
        public int X;
        public int Y;
        public string directia;
        public int numarul;
        public string cuvant;
        public string cerinta;

        public ClasaIdCelule(int x, int y, string d, int nr, string w, string c)
        {
            this.X = x;
            this.Y = y;
            this.directia = d;
            this.numarul = nr;
            this.cuvant = w;
            this.cerinta = c;
        }
    }
}
