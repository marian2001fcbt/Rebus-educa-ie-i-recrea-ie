namespace FormularTaburiDinamice
{
    partial class frmRecuperare
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeUtilizator = new System.Windows.Forms.Label();
            this.txtRecuperare = new System.Windows.Forms.TextBox();
            this.btnRecuperare = new System.Windows.Forms.Button();
            this.lblParola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti adresa de Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume de utilizator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola:";
            // 
            // lblNumeUtilizator
            // 
            this.lblNumeUtilizator.AutoSize = true;
            this.lblNumeUtilizator.Location = new System.Drawing.Point(232, 169);
            this.lblNumeUtilizator.Name = "lblNumeUtilizator";
            this.lblNumeUtilizator.Size = new System.Drawing.Size(77, 13);
            this.lblNumeUtilizator.TabIndex = 3;
            this.lblNumeUtilizator.Text = "nume_utilizator";
            // 
            // txtRecuperare
            // 
            this.txtRecuperare.Location = new System.Drawing.Point(195, 67);
            this.txtRecuperare.Name = "txtRecuperare";
            this.txtRecuperare.Size = new System.Drawing.Size(355, 20);
            this.txtRecuperare.TabIndex = 4;
            // 
            // btnRecuperare
            // 
            this.btnRecuperare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecuperare.Location = new System.Drawing.Point(257, 99);
            this.btnRecuperare.Name = "btnRecuperare";
            this.btnRecuperare.Size = new System.Drawing.Size(126, 36);
            this.btnRecuperare.TabIndex = 5;
            this.btnRecuperare.Text = "Recuperare";
            this.btnRecuperare.UseVisualStyleBackColor = true;
            this.btnRecuperare.Click += new System.EventHandler(this.btnRecuperare_Click);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(232, 196);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(80, 13);
            this.lblParola.TabIndex = 6;
            this.lblParola.Text = "parola_utilizator";
            // 
            // frmRecuperare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.btnRecuperare);
            this.Controls.Add(this.txtRecuperare);
            this.Controls.Add(this.lblNumeUtilizator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRecuperare";
            this.Text = "frmRecuperare";
            this.Load += new System.EventHandler(this.frmRecuperare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumeUtilizator;
        private System.Windows.Forms.TextBox txtRecuperare;
        private System.Windows.Forms.Button btnRecuperare;
        private System.Windows.Forms.Label lblParola;
    }
}