namespace FormularTaburiDinamice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rebuseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rebusDataSet = new FormularTaburiDinamice.RebusDataSet();
            this.rebuseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareRebusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperareContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectareRebusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiparireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delogareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireDinAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rebuseTableAdapter = new FormularTaburiDinamice.RebusDataSetTableAdapters.RebuseTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabPaginaRezolvare = new System.Windows.Forms.TabPage();
            this.txtSecundeRamase = new System.Windows.Forms.TextBox();
            this.txtMinuteRamase = new System.Windows.Forms.TextBox();
            this.txtOreRamase = new System.Windows.Forms.TextBox();
            this.txtSecundeEstimate = new System.Windows.Forms.TextBox();
            this.txtMinuteEstimate = new System.Windows.Forms.TextBox();
            this.txtOreEstimat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.ddlRebus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitRezolvare = new System.Windows.Forms.SplitContainer();
            this.dgvRebus = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCerinteVertical = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCerinteOrizontal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdaugareRebus = new System.Windows.Forms.TabPage();
            this.ddlRebusAdministrare = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitAdministrare = new System.Windows.Forms.SplitContainer();
            this.dgvRebusAdministrare = new System.Windows.Forms.DataGridView();
            this.dgvCerinteAdministrare = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.rebuseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebuseBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPaginaRezolvare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRezolvare)).BeginInit();
            this.splitRezolvare.Panel1.SuspendLayout();
            this.splitRezolvare.Panel2.SuspendLayout();
            this.splitRezolvare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRebus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerinteVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerinteOrizontal)).BeginInit();
            this.tabAdaugareRebus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAdministrare)).BeginInit();
            this.splitAdministrare.Panel1.SuspendLayout();
            this.splitAdministrare.Panel2.SuspendLayout();
            this.splitAdministrare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRebusAdministrare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerinteAdministrare)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rebuseBindingSource
            // 
            this.rebuseBindingSource.DataMember = "Rebuse";
            this.rebuseBindingSource.DataSource = this.rebusDataSet;
            // 
            // rebusDataSet
            // 
            this.rebusDataSet.DataSetName = "RebusDataSet";
            this.rebusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rebuseBindingSource1
            // 
            this.rebuseBindingSource1.DataMember = "Rebuse";
            this.rebuseBindingSource1.DataSource = this.rebusDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrareToolStripMenuItem,
            this.rebusToolStripMenuItem,
            this.iesireToolStripMenuItem1,
            this.ajutorToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // administrareToolStripMenuItem
            // 
            this.administrareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logareToolStripMenuItem,
            this.inregistrareToolStripMenuItem,
            this.adaugareRebusToolStripMenuItem,
            this.recuperareContToolStripMenuItem});
            this.administrareToolStripMenuItem.Name = "administrareToolStripMenuItem";
            this.administrareToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.administrareToolStripMenuItem.Text = "Administrare";
            // 
            // logareToolStripMenuItem
            // 
            this.logareToolStripMenuItem.Name = "logareToolStripMenuItem";
            this.logareToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.logareToolStripMenuItem.Text = "Logare";
            this.logareToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // inregistrareToolStripMenuItem
            // 
            this.inregistrareToolStripMenuItem.Name = "inregistrareToolStripMenuItem";
            this.inregistrareToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.inregistrareToolStripMenuItem.Text = "Inregistrare utilizator";
            this.inregistrareToolStripMenuItem.Click += new System.EventHandler(this.inregistrareToolStripMenuItem_Click);
            // 
            // adaugareRebusToolStripMenuItem
            // 
            this.adaugareRebusToolStripMenuItem.Name = "adaugareRebusToolStripMenuItem";
            this.adaugareRebusToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.adaugareRebusToolStripMenuItem.Text = "Adaugare rebus";
            this.adaugareRebusToolStripMenuItem.Click += new System.EventHandler(this.adaugareRebusToolStripMenuItem_Click);
            // 
            // recuperareContToolStripMenuItem
            // 
            this.recuperareContToolStripMenuItem.Name = "recuperareContToolStripMenuItem";
            this.recuperareContToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.recuperareContToolStripMenuItem.Text = "Recuperare cont";
            this.recuperareContToolStripMenuItem.Click += new System.EventHandler(this.recuperareContToolStripMenuItem_Click);
            // 
            // rebusToolStripMenuItem
            // 
            this.rebusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectareRebusToolStripMenuItem,
            this.tiparireToolStripMenuItem});
            this.rebusToolStripMenuItem.Name = "rebusToolStripMenuItem";
            this.rebusToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.rebusToolStripMenuItem.Text = "Rebus";
            // 
            // selectareRebusToolStripMenuItem
            // 
            this.selectareRebusToolStripMenuItem.Name = "selectareRebusToolStripMenuItem";
            this.selectareRebusToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.selectareRebusToolStripMenuItem.Text = "Selectare rebus";
            this.selectareRebusToolStripMenuItem.Click += new System.EventHandler(this.rezolvareRebusToolStripMenuItem_Click);
            // 
            // tiparireToolStripMenuItem
            // 
            this.tiparireToolStripMenuItem.Name = "tiparireToolStripMenuItem";
            this.tiparireToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.tiparireToolStripMenuItem.Text = "Tiparire";
            this.tiparireToolStripMenuItem.Click += new System.EventHandler(this.tiparireToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem1
            // 
            this.iesireToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delogareToolStripMenuItem,
            this.iesireDinAplicatieToolStripMenuItem});
            this.iesireToolStripMenuItem1.Name = "iesireToolStripMenuItem1";
            this.iesireToolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.iesireToolStripMenuItem1.Text = "Iesire";
            // 
            // delogareToolStripMenuItem
            // 
            this.delogareToolStripMenuItem.Name = "delogareToolStripMenuItem";
            this.delogareToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.delogareToolStripMenuItem.Text = "Delogare";
            this.delogareToolStripMenuItem.Click += new System.EventHandler(this.delogareToolStripMenuItem_Click);
            // 
            // iesireDinAplicatieToolStripMenuItem
            // 
            this.iesireDinAplicatieToolStripMenuItem.Name = "iesireDinAplicatieToolStripMenuItem";
            this.iesireDinAplicatieToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.iesireDinAplicatieToolStripMenuItem.Text = "Iesire din aplicatie";
            this.iesireDinAplicatieToolStripMenuItem.Click += new System.EventHandler(this.iesireDinAplicatieToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.ajutorToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.despreToolStripMenuItem.Text = "Despre";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rebuseTableAdapter
            // 
            this.rebuseTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabPaginaRezolvare
            // 
            this.tabPaginaRezolvare.Controls.Add(this.txtSecundeRamase);
            this.tabPaginaRezolvare.Controls.Add(this.txtMinuteRamase);
            this.tabPaginaRezolvare.Controls.Add(this.txtOreRamase);
            this.tabPaginaRezolvare.Controls.Add(this.txtSecundeEstimate);
            this.tabPaginaRezolvare.Controls.Add(this.txtMinuteEstimate);
            this.tabPaginaRezolvare.Controls.Add(this.txtOreEstimat);
            this.tabPaginaRezolvare.Controls.Add(this.label7);
            this.tabPaginaRezolvare.Controls.Add(this.label8);
            this.tabPaginaRezolvare.Controls.Add(this.label6);
            this.tabPaginaRezolvare.Controls.Add(this.label5);
            this.tabPaginaRezolvare.Controls.Add(this.label4);
            this.tabPaginaRezolvare.Controls.Add(this.label3);
            this.tabPaginaRezolvare.Controls.Add(this.btnSalvare);
            this.tabPaginaRezolvare.Controls.Add(this.ddlRebus);
            this.tabPaginaRezolvare.Controls.Add(this.label2);
            this.tabPaginaRezolvare.Controls.Add(this.splitRezolvare);
            this.tabPaginaRezolvare.Location = new System.Drawing.Point(4, 25);
            this.tabPaginaRezolvare.Margin = new System.Windows.Forms.Padding(4);
            this.tabPaginaRezolvare.Name = "tabPaginaRezolvare";
            this.tabPaginaRezolvare.Padding = new System.Windows.Forms.Padding(4);
            this.tabPaginaRezolvare.Size = new System.Drawing.Size(1336, 633);
            this.tabPaginaRezolvare.TabIndex = 1;
            this.tabPaginaRezolvare.Text = "Rezolvare rebus";
            this.tabPaginaRezolvare.UseVisualStyleBackColor = true;
            // 
            // txtSecundeRamase
            // 
            this.txtSecundeRamase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecundeRamase.Location = new System.Drawing.Point(372, 583);
            this.txtSecundeRamase.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecundeRamase.Name = "txtSecundeRamase";
            this.txtSecundeRamase.Size = new System.Drawing.Size(31, 26);
            this.txtSecundeRamase.TabIndex = 17;
            // 
            // txtMinuteRamase
            // 
            this.txtMinuteRamase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuteRamase.Location = new System.Drawing.Point(304, 583);
            this.txtMinuteRamase.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinuteRamase.Name = "txtMinuteRamase";
            this.txtMinuteRamase.Size = new System.Drawing.Size(31, 26);
            this.txtMinuteRamase.TabIndex = 15;
            // 
            // txtOreRamase
            // 
            this.txtOreRamase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOreRamase.Location = new System.Drawing.Point(237, 583);
            this.txtOreRamase.Margin = new System.Windows.Forms.Padding(4);
            this.txtOreRamase.Name = "txtOreRamase";
            this.txtOreRamase.Size = new System.Drawing.Size(31, 26);
            this.txtOreRamase.TabIndex = 13;
            // 
            // txtSecundeEstimate
            // 
            this.txtSecundeEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecundeEstimate.Location = new System.Drawing.Point(372, 527);
            this.txtSecundeEstimate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecundeEstimate.Name = "txtSecundeEstimate";
            this.txtSecundeEstimate.Size = new System.Drawing.Size(31, 26);
            this.txtSecundeEstimate.TabIndex = 12;
            // 
            // txtMinuteEstimate
            // 
            this.txtMinuteEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuteEstimate.Location = new System.Drawing.Point(304, 527);
            this.txtMinuteEstimate.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinuteEstimate.Name = "txtMinuteEstimate";
            this.txtMinuteEstimate.Size = new System.Drawing.Size(31, 26);
            this.txtMinuteEstimate.TabIndex = 10;
            // 
            // txtOreEstimat
            // 
            this.txtOreEstimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOreEstimat.Location = new System.Drawing.Point(237, 527);
            this.txtOreEstimat.Margin = new System.Windows.Forms.Padding(4);
            this.txtOreEstimat.Name = "txtOreEstimat";
            this.txtOreEstimat.Size = new System.Drawing.Size(31, 26);
            this.txtOreEstimat.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 587);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 587);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 581);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Timp ramas:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 530);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Timp estimat:";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(921, 570);
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(256, 42);
            this.btnSalvare.TabIndex = 5;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // ddlRebus
            // 
            this.ddlRebus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ddlRebus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlRebus.FormattingEnabled = true;
            this.ddlRebus.Location = new System.Drawing.Point(197, 4);
            this.ddlRebus.Margin = new System.Windows.Forms.Padding(4);
            this.ddlRebus.Name = "ddlRebus";
            this.ddlRebus.Size = new System.Drawing.Size(308, 33);
            this.ddlRebus.TabIndex = 4;
            this.ddlRebus.SelectedIndexChanged += new System.EventHandler(this.ddlRebus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectati un rebus:";
            // 
            // splitRezolvare
            // 
            this.splitRezolvare.Location = new System.Drawing.Point(37, 90);
            this.splitRezolvare.Margin = new System.Windows.Forms.Padding(4);
            this.splitRezolvare.Name = "splitRezolvare";
            // 
            // splitRezolvare.Panel1
            // 
            this.splitRezolvare.Panel1.Controls.Add(this.dgvRebus);
            // 
            // splitRezolvare.Panel2
            // 
            this.splitRezolvare.Panel2.Controls.Add(this.label10);
            this.splitRezolvare.Panel2.Controls.Add(this.label9);
            this.splitRezolvare.Panel2.Controls.Add(this.dgvCerinteVertical);
            this.splitRezolvare.Panel2.Controls.Add(this.dgvCerinteOrizontal);
            this.splitRezolvare.Size = new System.Drawing.Size(1263, 418);
            this.splitRezolvare.SplitterDistance = 577;
            this.splitRezolvare.SplitterWidth = 5;
            this.splitRezolvare.TabIndex = 2;
            // 
            // dgvRebus
            // 
            this.dgvRebus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRebus.ColumnHeadersVisible = false;
            this.dgvRebus.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvRebus.Location = new System.Drawing.Point(0, 0);
            this.dgvRebus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRebus.Name = "dgvRebus";
            this.dgvRebus.RowHeadersVisible = false;
            this.dgvRebus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRebus.Size = new System.Drawing.Size(577, 418);
            this.dgvRebus.TabIndex = 0;
            this.dgvRebus.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRebus_CellFormatting);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Vertical";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Orizontal";
            // 
            // dgvCerinteVertical
            // 
            this.dgvCerinteVertical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerinteVertical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dgvCerinteVertical.Location = new System.Drawing.Point(36, 242);
            this.dgvCerinteVertical.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCerinteVertical.Name = "dgvCerinteVertical";
            this.dgvCerinteVertical.RowHeadersVisible = false;
            this.dgvCerinteVertical.Size = new System.Drawing.Size(627, 172);
            this.dgvCerinteVertical.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cerinta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvCerinteOrizontal
            // 
            this.dgvCerinteOrizontal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerinteOrizontal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dgvCerinteOrizontal.Location = new System.Drawing.Point(36, 34);
            this.dgvCerinteOrizontal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCerinteOrizontal.Name = "dgvCerinteOrizontal";
            this.dgvCerinteOrizontal.RowHeadersVisible = false;
            this.dgvCerinteOrizontal.Size = new System.Drawing.Size(627, 159);
            this.dgvCerinteOrizontal.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Cerinta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabAdaugareRebus
            // 
            this.tabAdaugareRebus.Controls.Add(this.ddlRebusAdministrare);
            this.tabAdaugareRebus.Controls.Add(this.label1);
            this.tabAdaugareRebus.Controls.Add(this.splitAdministrare);
            this.tabAdaugareRebus.Location = new System.Drawing.Point(4, 25);
            this.tabAdaugareRebus.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdaugareRebus.Name = "tabAdaugareRebus";
            this.tabAdaugareRebus.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdaugareRebus.Size = new System.Drawing.Size(1336, 633);
            this.tabAdaugareRebus.TabIndex = 0;
            this.tabAdaugareRebus.Tag = "0";
            this.tabAdaugareRebus.Text = "Vizualizare rebus";
            this.tabAdaugareRebus.UseVisualStyleBackColor = true;
            this.tabAdaugareRebus.Click += new System.EventHandler(this.tabAdaugareRebus_Click);
            // 
            // ddlRebusAdministrare
            // 
            this.ddlRebusAdministrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlRebusAdministrare.FormattingEnabled = true;
            this.ddlRebusAdministrare.Location = new System.Drawing.Point(285, 32);
            this.ddlRebusAdministrare.Margin = new System.Windows.Forms.Padding(4);
            this.ddlRebusAdministrare.Name = "ddlRebusAdministrare";
            this.ddlRebusAdministrare.Size = new System.Drawing.Size(308, 33);
            this.ddlRebusAdministrare.TabIndex = 6;
            this.ddlRebusAdministrare.SelectedIndexChanged += new System.EventHandler(this.ddlRebusAdministrare_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selectati un rebus:";
            // 
            // splitAdministrare
            // 
            this.splitAdministrare.Location = new System.Drawing.Point(32, 111);
            this.splitAdministrare.Margin = new System.Windows.Forms.Padding(4);
            this.splitAdministrare.Name = "splitAdministrare";
            // 
            // splitAdministrare.Panel1
            // 
            this.splitAdministrare.Panel1.Controls.Add(this.dgvRebusAdministrare);
            // 
            // splitAdministrare.Panel2
            // 
            this.splitAdministrare.Panel2.Controls.Add(this.dgvCerinteAdministrare);
            this.splitAdministrare.Size = new System.Drawing.Size(1267, 418);
            this.splitAdministrare.SplitterDistance = 589;
            this.splitAdministrare.SplitterWidth = 5;
            this.splitAdministrare.TabIndex = 0;
            // 
            // dgvRebusAdministrare
            // 
            this.dgvRebusAdministrare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRebusAdministrare.ColumnHeadersVisible = false;
            this.dgvRebusAdministrare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRebusAdministrare.Location = new System.Drawing.Point(0, 0);
            this.dgvRebusAdministrare.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRebusAdministrare.Name = "dgvRebusAdministrare";
            this.dgvRebusAdministrare.RowHeadersVisible = false;
            this.dgvRebusAdministrare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRebusAdministrare.Size = new System.Drawing.Size(589, 418);
            this.dgvRebusAdministrare.TabIndex = 0;
            this.dgvRebusAdministrare.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRebusAdministrare_CellFormatting);
            this.dgvRebusAdministrare.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRebusAdministrare_CellPainting);
            // 
            // dgvCerinteAdministrare
            // 
            this.dgvCerinteAdministrare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerinteAdministrare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCerinteAdministrare.Location = new System.Drawing.Point(23, 21);
            this.dgvCerinteAdministrare.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCerinteAdministrare.Name = "dgvCerinteAdministrare";
            this.dgvCerinteAdministrare.Size = new System.Drawing.Size(635, 375);
            this.dgvCerinteAdministrare.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "#";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Directia";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Cerinta";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabAdaugareRebus);
            this.tabPrincipal.Controls.Add(this.tabPaginaRezolvare);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 28);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1344, 662);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Tag = "1";
            this.tabPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 690);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rebus || Crossword";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rebuseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebuseBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPaginaRezolvare.ResumeLayout(false);
            this.tabPaginaRezolvare.PerformLayout();
            this.splitRezolvare.Panel1.ResumeLayout(false);
            this.splitRezolvare.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRezolvare)).EndInit();
            this.splitRezolvare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRebus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerinteVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerinteOrizontal)).EndInit();
            this.tabAdaugareRebus.ResumeLayout(false);
            this.tabAdaugareRebus.PerformLayout();
            this.splitAdministrare.Panel1.ResumeLayout(false);
            this.splitAdministrare.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAdministrare)).EndInit();
            this.splitAdministrare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRebusAdministrare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerinteAdministrare)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareRebusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectareRebusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logareToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private RebusDataSet rebusDataSet;
        private System.Windows.Forms.BindingSource rebuseBindingSource;
        private RebusDataSetTableAdapters.RebuseTableAdapter rebuseTableAdapter;
        private System.Windows.Forms.BindingSource rebuseBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem tiparireToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem delogareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireDinAplicatieToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem recuperareContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPaginaRezolvare;
        private System.Windows.Forms.TextBox txtSecundeRamase;
        private System.Windows.Forms.TextBox txtMinuteRamase;
        private System.Windows.Forms.TextBox txtOreRamase;
        private System.Windows.Forms.TextBox txtSecundeEstimate;
        private System.Windows.Forms.TextBox txtMinuteEstimate;
        private System.Windows.Forms.TextBox txtOreEstimat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ComboBox ddlRebus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitRezolvare;
        private System.Windows.Forms.DataGridView dgvRebus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCerinteVertical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvCerinteOrizontal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabAdaugareRebus;
        private System.Windows.Forms.ComboBox ddlRebusAdministrare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitAdministrare;
        private System.Windows.Forms.DataGridView dgvRebusAdministrare;
        private System.Windows.Forms.DataGridView dgvCerinteAdministrare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabPrincipal;
    }
}

