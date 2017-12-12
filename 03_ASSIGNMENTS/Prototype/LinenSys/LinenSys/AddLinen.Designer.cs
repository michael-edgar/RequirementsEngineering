namespace LinenSys
{
    partial class frmAddLinen
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
            this.grpLinen = new System.Windows.Forms.GroupBox();
            this.txtRejectPrice = new System.Windows.Forms.TextBox();
            this.txtCleaningPrice = new System.Windows.Forms.TextBox();
            this.txtHirePrice = new System.Windows.Forms.TextBox();
            this.txtLinenCode = new System.Windows.Forms.TextBox();
            this.txtLinenName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLinen = new System.Windows.Forms.Button();
            this.mnuAddLinen = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.grpLinen.SuspendLayout();
            this.mnuAddLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLinen
            // 
            this.grpLinen.Controls.Add(this.txtPackSize);
            this.grpLinen.Controls.Add(this.label6);
            this.grpLinen.Controls.Add(this.txtRejectPrice);
            this.grpLinen.Controls.Add(this.txtCleaningPrice);
            this.grpLinen.Controls.Add(this.txtHirePrice);
            this.grpLinen.Controls.Add(this.txtLinenCode);
            this.grpLinen.Controls.Add(this.txtLinenName);
            this.grpLinen.Controls.Add(this.label5);
            this.grpLinen.Controls.Add(this.label4);
            this.grpLinen.Controls.Add(this.label3);
            this.grpLinen.Controls.Add(this.label2);
            this.grpLinen.Controls.Add(this.label1);
            this.grpLinen.Location = new System.Drawing.Point(12, 48);
            this.grpLinen.Name = "grpLinen";
            this.grpLinen.Size = new System.Drawing.Size(273, 286);
            this.grpLinen.TabIndex = 5;
            this.grpLinen.TabStop = false;
            this.grpLinen.Text = "Linen";
            // 
            // txtRejectPrice
            // 
            this.txtRejectPrice.Location = new System.Drawing.Point(121, 205);
            this.txtRejectPrice.Name = "txtRejectPrice";
            this.txtRejectPrice.Size = new System.Drawing.Size(146, 20);
            this.txtRejectPrice.TabIndex = 14;
            // 
            // txtCleaningPrice
            // 
            this.txtCleaningPrice.Location = new System.Drawing.Point(121, 163);
            this.txtCleaningPrice.Name = "txtCleaningPrice";
            this.txtCleaningPrice.Size = new System.Drawing.Size(146, 20);
            this.txtCleaningPrice.TabIndex = 13;
            // 
            // txtHirePrice
            // 
            this.txtHirePrice.Location = new System.Drawing.Point(121, 113);
            this.txtHirePrice.Name = "txtHirePrice";
            this.txtHirePrice.Size = new System.Drawing.Size(146, 20);
            this.txtHirePrice.TabIndex = 12;
            // 
            // txtLinenCode
            // 
            this.txtLinenCode.Location = new System.Drawing.Point(121, 62);
            this.txtLinenCode.Name = "txtLinenCode";
            this.txtLinenCode.Size = new System.Drawing.Size(146, 20);
            this.txtLinenCode.TabIndex = 11;
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
            this.label5.Location = new System.Drawing.Point(6, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reject Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cleaning Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hire Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Linen Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Linen Name:";
            // 
            // btnAddLinen
            // 
            this.btnAddLinen.Location = new System.Drawing.Point(254, 340);
            this.btnAddLinen.Name = "btnAddLinen";
            this.btnAddLinen.Size = new System.Drawing.Size(75, 23);
            this.btnAddLinen.TabIndex = 6;
            this.btnAddLinen.Text = "Save";
            this.btnAddLinen.UseVisualStyleBackColor = true;
            this.btnAddLinen.Click += new System.EventHandler(this.btnAddLinen_Click);
            // 
            // mnuAddLinen
            // 
            this.mnuAddLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuAddLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuAddLinen.Name = "mnuAddLinen";
            this.mnuAddLinen.Size = new System.Drawing.Size(560, 24);
            this.mnuAddLinen.TabIndex = 7;
            this.mnuAddLinen.Text = "mnuAddLinen";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pack Size:";
            // 
            // txtPackSize
            // 
            this.txtPackSize.Location = new System.Drawing.Point(121, 245);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(146, 20);
            this.txtPackSize.TabIndex = 16;
            // 
            // frmAddLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 378);
            this.Controls.Add(this.btnAddLinen);
            this.Controls.Add(this.grpLinen);
            this.Controls.Add(this.mnuAddLinen);
            this.MainMenuStrip = this.mnuAddLinen;
            this.Name = "frmAddLinen";
            this.Text = "Add Linen";
            this.Load += new System.EventHandler(this.frmAddLinen_Load);
            this.grpLinen.ResumeLayout(false);
            this.grpLinen.PerformLayout();
            this.mnuAddLinen.ResumeLayout(false);
            this.mnuAddLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLinen;
        private System.Windows.Forms.TextBox txtRejectPrice;
        private System.Windows.Forms.TextBox txtCleaningPrice;
        private System.Windows.Forms.TextBox txtHirePrice;
        private System.Windows.Forms.TextBox txtLinenCode;
        private System.Windows.Forms.TextBox txtLinenName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddLinen;
        private System.Windows.Forms.MenuStrip mnuAddLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label label6;
    }
}

