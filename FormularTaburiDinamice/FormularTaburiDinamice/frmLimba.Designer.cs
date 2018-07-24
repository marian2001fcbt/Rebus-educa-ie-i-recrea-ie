namespace FormularTaburiDinamice
{
    partial class frmLimba
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
            this.btnEngleza = new System.Windows.Forms.Button();
            this.btnRomana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEngleza
            // 
            this.btnEngleza.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEngleza.BackgroundImage = global::FormularTaburiDinamice.Properties.Resources.United_Kingdom_Flag;
            this.btnEngleza.Location = new System.Drawing.Point(381, 12);
            this.btnEngleza.Name = "btnEngleza";
            this.btnEngleza.Size = new System.Drawing.Size(339, 280);
            this.btnEngleza.TabIndex = 1;
            this.btnEngleza.UseVisualStyleBackColor = false;
            this.btnEngleza.Click += new System.EventHandler(this.btnEngleza_Click);
            // 
            // btnRomana
            // 
            this.btnRomana.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRomana.BackgroundImage = global::FormularTaburiDinamice.Properties.Resources.Romania_Flag;
            this.btnRomana.Location = new System.Drawing.Point(29, 12);
            this.btnRomana.Name = "btnRomana";
            this.btnRomana.Size = new System.Drawing.Size(346, 280);
            this.btnRomana.TabIndex = 0;
            this.btnRomana.UseVisualStyleBackColor = false;
            this.btnRomana.Click += new System.EventHandler(this.btnRomana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(161, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Română";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(539, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "English";
            // 
            // frmLimba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEngleza);
            this.Controls.Add(this.btnRomana);
            this.Name = "frmLimba";
            this.Text = "Limba || Language";
            this.Load += new System.EventHandler(this.frmLimba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRomana;
        private System.Windows.Forms.Button btnEngleza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}