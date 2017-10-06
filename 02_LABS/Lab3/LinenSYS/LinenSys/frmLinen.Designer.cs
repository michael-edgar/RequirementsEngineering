namespace LinenSys
{
    partial class frmLinen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLinenId = new System.Windows.Forms.TextBox();
            this.txtLinenName = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCleaningPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linen Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Linen ID";
            this.label2.BindingContextChanged += new System.EventHandler(this.S);
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLinenId
            // 
            this.txtLinenId.Enabled = false;
            this.txtLinenId.Location = new System.Drawing.Point(315, 39);
            this.txtLinenId.Name = "txtLinenId";
            this.txtLinenId.Size = new System.Drawing.Size(100, 20);
            this.txtLinenId.TabIndex = 10;
            this.txtLinenId.Text = "001";
            // 
            // txtLinenName
            // 
            this.txtLinenName.Location = new System.Drawing.Point(315, 85);
            this.txtLinenName.Name = "txtLinenName";
            this.txtLinenName.Size = new System.Drawing.Size(189, 20);
            this.txtLinenName.TabIndex = 11;
            this.txtLinenName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(315, 147);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(189, 20);
            this.txtSalePrice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sale Price";
            // 
            // txtCleaningPrice
            // 
            this.txtCleaningPrice.Location = new System.Drawing.Point(315, 201);
            this.txtCleaningPrice.Name = "txtCleaningPrice";
            this.txtCleaningPrice.Size = new System.Drawing.Size(189, 20);
            this.txtCleaningPrice.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cleaning Price";
            // 
            // txtPackSize
            // 
            this.txtPackSize.Location = new System.Drawing.Point(315, 265);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(189, 20);
            this.txtPackSize.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pack Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Confirm Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPackSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCleaningPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLinenName);
            this.Controls.Add(this.txtLinenId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLinen";
            this.Text = "Linen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLinenId;
        private System.Windows.Forms.TextBox txtLinenName;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCleaningPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

