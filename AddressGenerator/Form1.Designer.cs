
namespace AddressGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShow = new System.Windows.Forms.Label();
            this.txtLongAddress = new System.Windows.Forms.TextBox();
            this.txtGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShortAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneratorR = new System.Windows.Forms.Button();
            this.txtLongAddressR = new System.Windows.Forms.TextBox();
            this.txtShortAddressR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(520, -78);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(63, 15);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "ShortCode";
            // 
            // txtLongAddress
            // 
            this.txtLongAddress.Location = new System.Drawing.Point(6, 22);
            this.txtLongAddress.Name = "txtLongAddress";
            this.txtLongAddress.Size = new System.Drawing.Size(280, 23);
            this.txtLongAddress.TabIndex = 2;
            this.txtLongAddress.Text = "sample: https://www.google.com/data/layer/123";
            this.txtLongAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLongAddress.TextChanged += new System.EventHandler(this.txLongAddresst_TextChanged);
            // 
            // txtGenerate
            // 
            this.txtGenerate.Location = new System.Drawing.Point(292, 22);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(75, 23);
            this.txtGenerate.TabIndex = 3;
            this.txtGenerate.Text = "Generator";
            this.txtGenerate.UseVisualStyleBackColor = true;
            this.txtGenerate.Click += new System.EventHandler(this.txtGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtShortAddress);
            this.groupBox1.Controls.Add(this.txtLongAddress);
            this.groupBox1.Controls.Add(this.lblShow);
            this.groupBox1.Controls.Add(this.txtGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Short Address Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Short Address:";
            // 
            // txtShortAddress
            // 
            this.txtShortAddress.Location = new System.Drawing.Point(490, 21);
            this.txtShortAddress.Name = "txtShortAddress";
            this.txtShortAddress.Size = new System.Drawing.Size(256, 23);
            this.txtShortAddress.TabIndex = 4;
            this.txtShortAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeneratorR);
            this.groupBox2.Controls.Add(this.txtLongAddressR);
            this.groupBox2.Controls.Add(this.txtShortAddressR);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 58);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Long Address Reminder";
            // 
            // btnGeneratorR
            // 
            this.btnGeneratorR.Location = new System.Drawing.Point(292, 23);
            this.btnGeneratorR.Name = "btnGeneratorR";
            this.btnGeneratorR.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratorR.TabIndex = 3;
            this.btnGeneratorR.Text = "Reminder";
            this.btnGeneratorR.UseVisualStyleBackColor = true;
            this.btnGeneratorR.Click += new System.EventHandler(this.btnGeneratorR_Click);
            // 
            // txtLongAddressR
            // 
            this.txtLongAddressR.Location = new System.Drawing.Point(490, 22);
            this.txtLongAddressR.Name = "txtLongAddressR";
            this.txtLongAddressR.Size = new System.Drawing.Size(256, 23);
            this.txtLongAddressR.TabIndex = 2;
            this.txtLongAddressR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtShortAddressR
            // 
            this.txtShortAddressR.Location = new System.Drawing.Point(6, 23);
            this.txtShortAddressR.Name = "txtShortAddressR";
            this.txtShortAddressR.Size = new System.Drawing.Size(280, 23);
            this.txtShortAddressR.TabIndex = 1;
            this.txtShortAddressR.Text = "sample: https://www.google.com/GhjKdL";
            this.txtShortAddressR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Long Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 161);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txLongAddresst;
        private System.Windows.Forms.TextBox txtLongAddress;
        private System.Windows.Forms.Button txtGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtShot;
        private System.Windows.Forms.TextBox txtShortAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGeneratorR;
        private System.Windows.Forms.TextBox txtLongAddressR;
        private System.Windows.Forms.TextBox txtShortAddressR;
        private System.Windows.Forms.Label label2;
    }
}

