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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addLinenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddLinen frmNextForm = new frmAddLinen();
            frmNextForm.Show();
        }

        private void updateLinenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateLinen frmNextForm = new frmUpdateLinen();
            frmNextForm.Show();
        }

        private void removeLinenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveLinen frmNextForm = new frmRemoveLinen();
            frmNextForm.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void logOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dispatchDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void collectLaundryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void calculateEarningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void calculateCustomerEarningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void recordRejectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void trackRejectCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
