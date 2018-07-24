using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormularTaburiDinamice
{
    public partial class frmLimba : Form
    {
        public frmLimba()
        {
            InitializeComponent();
        }

        private void frmLimba_Load(object sender, EventArgs e)
        {

        }

        private void btnRomana_Click(object sender, EventArgs e)
        {
            Auxiliare.Limba = 1;
            Auxiliare.UtilizatorLogat = 3;
            this.Close();
        }

        private void btnEngleza_Click(object sender, EventArgs e)
        {
            Auxiliare.Limba = 2;
            Auxiliare.UtilizatorLogat = 3;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
        }

    }
 
}
