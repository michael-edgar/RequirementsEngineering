﻿using System;
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
            frmAddLinen frmNextForm = new frmAddLinen(this);
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
            frmAddCustomer frmNextForm = new frmAddCustomer();
            frmNextForm.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer frmNextForm = new frmUpdateCustomer();
            frmNextForm.Show();
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCustomer frmNextForm = new frmRemoveCustomer();
            frmNextForm.Show();
        }

        private void logOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogOrder frmNextForm = new frmLogOrder();
            frmNextForm.Show();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelOrder frmNextForm = new frmCancelOrder();
            frmNextForm.Show();

        }

        private void dispatchDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDispatchDelivery frmNextForm = new frmDispatchDelivery();
            frmNextForm.Show();
        }

        private void collectLaundryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollectLaundry frmNextForm = new frmCollectLaundry();
            frmNextForm.Show();
        }

        private void calculateEarningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalculateEarnings frmNextForm = new frmCalculateEarnings();
            frmNextForm.Show();
        }

        private void calculateCustomerEarningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalculateCustomerEarnings frmNextForm = new frmCalculateCustomerEarnings();
            frmNextForm.Show();
        }

        private void recordRejectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecordRejects frmNextForm = new frmRecordRejects();
            frmNextForm.Show();
        }

        private void trackRejectCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrackRejectCost frmNextForm = new frmTrackRejectCost();
            frmNextForm.Show();
        }
    }
}
