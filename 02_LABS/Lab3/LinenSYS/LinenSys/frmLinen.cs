using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinenSys
{
    public partial class frmLinen : Form
    {
        public frmLinen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboLinen_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpGender.Visible = true;
            radSmoker.Visible = true;
            radNonSmoker.Visible = true;
            dtpDOB.Visible = true;
        }

        private void radNonSmoker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void S(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
