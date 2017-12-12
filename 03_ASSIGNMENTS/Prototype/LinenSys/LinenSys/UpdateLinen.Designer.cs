namespace LinenSys
{
    partial class frmUpdateLinen
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
            this.txtLinenCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetLinen = new System.Windows.Forms.Button();
            this.cboLinenNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLinen = new System.Windows.Forms.GroupBox();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRejectPrice = new System.Windows.Forms.TextBox();
            this.txtCleaningPrice = new System.Windows.Forms.TextBox();
            this.txtHirePrice = new System.Windows.Forms.TextBox();
            this.txtLinenName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateLinen = new System.Windows.Forms.Button();
            this.mnuUpdateLinen = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLinen.SuspendLayout();
            this.mnuUpdateLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLinenCode
            // 
            this.txtLinenCode.Location = new System.Drawing.Point(163, 53);
            this.txtLinenCode.Name = "txtLinenCode";
            this.txtLinenCode.Size = new System.Drawing.Size(123, 20);
            this.txtLinenCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linen Code";
            // 
            // btnGetLinen
            // 
            this.btnGetLinen.Location = new System.Drawing.Point(112, 104);
            this.btnGetLinen.Name = "btnGetLinen";
            this.btnGetLinen.Size = new System.Drawing.Size(75, 23);
            this.btnGetLinen.TabIndex = 2;
            this.btnGetLinen.Text = "Get Linen";
            this.btnGetLinen.UseVisualStyleBackColor = true;
            this.btnGetLinen.Click += new System.EventHandler(this.btnGetLinen_Click);
            // 
            // cboLinenNames
            // 
            this.cboLinenNames.FormattingEnabled = true;
            this.cboLinenNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboLinenNames.Location = new System.Drawing.Point(163, 198);
            this.cboLinenNames.Name = "cboLinenNames";
            this.cboLinenNames.Size = new System.Drawing.Size(123, 21);
            this.cboLinenNames.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Linen Names";
            // 
            // grpLinen
            // 
            this.grpLinen.Controls.Add(this.txtPackSize);
            this.grpLinen.Controls.Add(this.label6);
            this.grpLinen.Controls.Add(this.txtRejectPrice);
            this.grpLinen.Controls.Add(this.txtCleaningPrice);
            this.grpLinen.Controls.Add(this.txtHirePrice);
            this.grpLinen.Controls.Add(this.txtLinenName);
            this.grpLinen.Controls.Add(this.label5);
            this.grpLinen.Controls.Add(this.label4);
            this.grpLinen.Controls.Add(this.label3);
            this.grpLinen.Controls.Add(this.label8);
            this.grpLinen.Location = new System.Drawing.Point(457, 53);
            this.grpLinen.Name = "grpLinen";
            this.grpLinen.Size = new System.Drawing.Size(273, 226);
            this.grpLinen.TabIndex = 6;
            this.grpLinen.TabStop = false;
            this.grpLinen.Text = "Linen";
            this.grpLinen.Visible = false;
            // 
            // txtPackSize
            // 
            this.txtPackSize.Location = new System.Drawing.Point(121, 186);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(146, 20);
            this.txtPackSize.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pack Size:";
            // 
            // txtRejectPrice
            // 
            this.txtRejectPrice.Location = new System.Drawing.Point(121, 146);
            this.txtRejectPrice.Name = "txtRejectPrice";
            this.txtRejectPrice.Size = new System.Drawing.Size(146, 20);
            this.txtRejectPrice.TabIndex = 14;
            // 
            // txtCleaningPrice
            // 
            this.txtCleaningPrice.Location = new System.Drawing.Point(121, 104);
            this.txtCleaningPrice.Name = "txtCleaningPrice";
            this.txtCleaningPrice.Size = new System.Drawing.Size(146, 20);
            this.txtCleaningPrice.TabIndex = 13;
            // 
            // txtHirePrice
            // 
            this.txtHirePrice.Location = new System.Drawing.Point(121, 54);
            this.txtHirePrice.Name = "txtHirePrice";
            this.txtHirePrice.Size = new System.Drawing.Size(146, 20);
            this.txtHirePrice.TabIndex = 12;
            // 
            // txtLinenName
            // 
            this.txtLinenName.Location = new System.Drawing.Point(121, 13);
            this.txtLinenName.Name = "txtLinenName";
            this.txtLinenName.Size = new System.Drawing.Size(146, 20);
            this.txtLinenName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reject Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cleaning Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hire Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Linen Name:";
            // 
            // btnUpdateLinen
            // 
            this.btnUpdateLinen.Location = new System.Drawing.Point(562, 285);
            this.btnUpdateLinen.Name = "btnUpdateLinen";
            this.btnUpdateLinen.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLinen.TabIndex = 7;
            this.btnUpdateLinen.Text = "Save";
            this.btnUpdateLinen.UseVisualStyleBackColor = true;
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(795, 24);
            this.mnuUpdateLinen.TabIndex = 8;
            this.mnuUpdateLinen.Text = "mnuUpdateLinen";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // frmUpdateLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Controls.Add(this.btnUpdateLinen);
            this.Controls.Add(this.grpLinen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLinenNames);
            this.Controls.Add(this.btnGetLinen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLinenCode);
            this.Name = "frmUpdateLinen";
            this.Text = "UpdateLinen";
            this.grpLinen.ResumeLayout(false);
            this.grpLinen.PerformLayout();
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinenCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLinen;
        private System.Windows.Forms.ComboBox cboLinenNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpLinen;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRejectPrice;
        private System.Windows.Forms.TextBox txtCleaningPrice;
        private System.Windows.Forms.TextBox txtHirePrice;
        private System.Windows.Forms.TextBox txtLinenName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateLinen;
        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}