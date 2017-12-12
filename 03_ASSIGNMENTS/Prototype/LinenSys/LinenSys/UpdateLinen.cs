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
    public partial class frmUpdateLinen : Form
    {
        frmMainMenu parent;
        public frmUpdateLinen(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnGetLinen_Click(object sender, EventArgs e)
        {
            String linenCode = txtLinenCode.Text;
            linenCode = linenCode.ToLower();

            if (linenCode.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
                txtLinenName.Focus();
                return;
            }

            else if (linenCode.StartsWith("b"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Text = "Bath Sheet" + "Bath Mat";
            }

            else if (linenCode.StartsWith("h"))
            {

            }

            else if (linenCode.StartsWith("s"))
            {

            }

            else if (linenCode.StartsWith("k"))
            {

            }

            else if (linenCode.StartsWith("p"))
            {

            }

            else
            {

            }
        }

        private void btnUpdateLinen_Click(object sender, EventArgs e)
        {
            //validate data
            float check;
            int checkInt;

            if (txtLinenName.Text.Equals(""))
            {
                MessageBox.Show("Linen Name must be entered", "Error");
                txtLinenName.Focus();
                return;
            }

            if (!float.TryParse(txtHirePrice.Text, out check))
            {
                MessageBox.Show("Hire Price must be numeric", "Error");
                txtHirePrice.Focus();
                return;
            }

            if (!float.TryParse(txtCleaningPrice.Text, out check))
            {
                MessageBox.Show("Cleaning Price must be numeric", "Error");
                txtCleaningPrice.Focus();
                return;
            }

            if (!float.TryParse(txtRejectPrice.Text, out check))
            {
                MessageBox.Show("Reject Price must be numeric", "Error");
                txtRejectPrice.Focus();
                return;
            }

            if (!int.TryParse(txtPackSize.Text, out checkInt))
            {
                MessageBox.Show("Pack Size must be numeric", "Error");
                return;
            }

            else
            {
                String addedLinen;
                addedLinen = "\nLinen Name: " + txtLinenName.Text + "\nLinen Code: " + txtLinenCode.Text +
                             "\nHire Price: " + txtHirePrice.Text + "\nCleaning Price: " +
                             txtCleaningPrice.Text + "\nReject Price: " + txtRejectPrice.Text;

                MessageBox.Show("The new Linen has been added to the system." + addedLinen, "Added Linen");
                txtLinenName.Clear();
                txtLinenCode.Clear();
                txtHirePrice.Clear();
                txtCleaningPrice.Clear();
                txtRejectPrice.Clear();
                txtPackSize.Clear();
                return;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
