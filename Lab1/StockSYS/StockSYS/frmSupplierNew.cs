using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSYS
{
    public partial class frmSupplierNew : Form
    {
        public frmSupplierNew()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //Validate Data
            if(txtSuppName.Text.Equals(""))
            {
                MessageBox.Show("This Field Must Be Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuppName.Focus();
                return;
            }

            //set Default Values


            //save data in supplier file


            //display confirmation message
            MessageBox.Show("Supplier has been added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSuppID.Text = "013";
            txtSuppName.Text = "";
            txtContact.Text = "";
            txtSuppName.Focus();
        }
    }
}
