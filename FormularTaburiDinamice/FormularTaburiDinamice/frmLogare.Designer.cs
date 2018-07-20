namespace FormularTaburiDinamice
{
    partial class frmLogare
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeLogare = new System.Windows.Forms.TextBox();
            this.txtParolaLogare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkInregistrare = new System.Windows.Forms.LinkLabel();
            this.btnLogare = new System.Windows.Forms.Button();
            this.btnVizitator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume utilizator:";
            // 
            // txtNumeLogare
            // 
            this.txtNumeLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeLogare.Location = new System.Drawing.Point(275, 79);
            this.txtNumeLogare.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeLogare.Name = "txtNumeLogare";
            this.txtNumeLogare.Size = new System.Drawing.Size(271, 26);
            this.txtNumeLogare.TabIndex = 1;
            // 
            // txtParolaLogare
            // 
            this.txtParolaLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParolaLogare.Location = new System.Drawing.Point(275, 156);
            this.txtParolaLogare.Margin = new System.Windows.Forms.Padding(4);
            this.txtParolaLogare.Name = "txtParolaLogare";
            this.txtParolaLogare.PasswordChar = '*';
            this.txtParolaLogare.Size = new System.Drawing.Size(271, 26);
            this.txtParolaLogare.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // lnkInregistrare
            // 
            this.lnkInregistrare.AutoSize = true;
            this.lnkInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkInregistrare.Location = new System.Drawing.Point(321, 287);
            this.lnkInregistrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkInregistrare.Name = "lnkInregistrare";
            this.lnkInregistrare.Size = new System.Drawing.Size(106, 20);
            this.lnkInregistrare.TabIndex = 4;
            this.lnkInregistrare.TabStop = true;
            this.lnkInregistrare.Text = "Inregistrare";
            this.lnkInregistrare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInregistrare_LinkClicked);
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(167, 213);
            this.btnLogare.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(208, 43);
            this.btnLogare.TabIndex = 5;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // btnVizitator
            // 
            this.btnVizitator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVizitator.Location = new System.Drawing.Point(383, 213);
            this.btnVizitator.Margin = new System.Windows.Forms.Padding(4);
            this.btnVizitator.Name = "btnVizitator";
            this.btnVizitator.Size = new System.Drawing.Size(208, 43);
            this.btnVizitator.TabIndex = 6;
            this.btnVizitator.Text = "Vizitator";
            this.btnVizitator.UseVisualStyleBackColor = true;
            this.btnVizitator.Click += new System.EventHandler(this.btnVizitator_Click);
            // 
            // frmLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 389);
            this.Controls.Add(this.btnVizitator);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lnkInregistrare);
            this.Controls.Add(this.txtParolaLogare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeLogare);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogare_FormClosing);
            this.Load += new System.EventHandler(this.frmLogare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeLogare;
        private System.Windows.Forms.TextBox txtParolaLogare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkInregistrare;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Button btnVizitator;
    }
}