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
            this.grpAddLinen = new System.Windows.Forms.GroupBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddLinen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddLinen
            // 
            this.grpAddLinen.Controls.Add(this.txtRejectPrice);
            this.grpAddLinen.Controls.Add(this.txtCleaningPrice);
            this.grpAddLinen.Controls.Add(this.txtHirePrice);
            this.grpAddLinen.Controls.Add(this.txtLinenCode);
            this.grpAddLinen.Controls.Add(this.txtLinenName);
            this.grpAddLinen.Controls.Add(this.label5);
            this.grpAddLinen.Controls.Add(this.label4);
            this.grpAddLinen.Controls.Add(this.label3);
            this.grpAddLinen.Controls.Add(this.label2);
            this.grpAddLinen.Controls.Add(this.label1);
            this.grpAddLinen.Location = new System.Drawing.Point(12, 48);
            this.grpAddLinen.Name = "grpAddLinen";
            this.grpAddLinen.Size = new System.Drawing.Size(273, 240);
            this.grpAddLinen.TabIndex = 5;
            this.grpAddLinen.TabStop = false;
            this.grpAddLinen.Text = "Add Linen";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmAddLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 375);
            this.Controls.Add(this.btnAddLinen);
            this.Controls.Add(this.grpAddLinen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddLinen";
            this.Text = "Add Linen";
            this.Load += new System.EventHandler(this.frmAddLinen_Load);
            this.grpAddLinen.ResumeLayout(false);
            this.grpAddLinen.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddLinen;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}

