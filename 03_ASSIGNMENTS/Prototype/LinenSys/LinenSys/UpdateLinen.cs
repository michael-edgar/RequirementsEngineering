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
                txtLinenCode.Focus();
                return;
            }

            else if (linenCode.StartsWith("b"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Bath Mat");
                cboLinenNames.Items.Add("Bath Sheet");
            }

            else if (linenCode.StartsWith("h"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Hand Towel");
            }

            else if (linenCode.StartsWith("s"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Single Sheet");
                cboLinenNames.Items.Add("Single Duvet");
            }

            else if (linenCode.StartsWith("k"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("King Sheet");
                cboLinenNames.Items.Add("King Duvet");
            }

            else if (linenCode.StartsWith("p"))
            {
                lblLinenNames.Visible = true;
                cboLinenNames.Visible = true;
                cboLinenNames.Items.Add("Pillow Slip");
            }

            else
            {
                MessageBox.Show("No active linen matching linen code was found, please re-enter");
                txtLinenCode.Focus();
                return;
            }
        }

        private void btnUpdateLinen_Click(object sender, EventArgs e)
        {
            //validate data
            float check;
            int checkInt;

            if (txtLinenName.Text.Equals("") && txtHirePrice.Text.Equals("") && txtCleaningPrice.Text.Equals("") && txtRejectPrice.Text.Equals("") && txtPackSize.Text.Equals(""))
            {
                MessageBox.Show("At least one field must be entered", "Error");
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
                String updateLinen;
                updateLinen = "\nLinen Name: " + txtLinenName.Text + "\nLinen Code: " + txtLinenCode.Text +
                             "\nHire Price: " + txtHirePrice.Text + "\nCleaning Price: " +
                             txtCleaningPrice.Text + "\nReject Price: " + txtRejectPrice.Text;

                MessageBox.Show("The updated lined has been saved to the system." + updateLinen, "Update Linen");
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

        private void cboLinenNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpLinen.Visible = true;
            if(cboLinenNames.SelectedText.Equals("Hand Towel"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("Bath Sheet"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("Bath Mat"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("Single Sheet"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("Single Duvet"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("King Sheet"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("King Duvet"))
            {

            }
            else if(cboLinenNames.SelectedText.Equals("Pillow Slip"))
            {

            }
        }
    }
}
