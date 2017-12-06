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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(41, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmUpdateLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLinenNames);
            this.Controls.Add(this.btnGetLinen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLinenCode);
            this.Name = "frmUpdateLinen";
            this.Text = "UpdateLinen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinenCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLinen;
        private System.Windows.Forms.ComboBox cboLinenNames;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}