
namespace Sig
{
    partial class encryptForm
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
            this.lbInput = new System.Windows.Forms.Label();
            this.lbSeed = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbOTP = new System.Windows.Forms.Label();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.btnMain = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.btnRandomSeed = new System.Windows.Forms.Button();
            this.btnCopyOTP = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopyOutput = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(12, 9);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(38, 15);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Input:";
            // 
            // lbSeed
            // 
            this.lbSeed.AutoSize = true;
            this.lbSeed.Location = new System.Drawing.Point(12, 63);
            this.lbSeed.Name = "lbSeed";
            this.lbSeed.Size = new System.Drawing.Size(35, 15);
            this.lbSeed.TabIndex = 3;
            this.lbSeed.Text = "Seed:";
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(12, 139);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(363, 23);
            this.txtOTP.TabIndex = 8;
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(12, 84);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(363, 23);
            this.txtSeed.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(482, 23);
            this.txtInput.TabIndex = 0;
            // 
            // lbOTP
            // 
            this.lbOTP.AutoSize = true;
            this.lbOTP.Location = new System.Drawing.Point(12, 118);
            this.lbOTP.Name = "lbOTP";
            this.lbOTP.Size = new System.Drawing.Size(82, 15);
            this.lbOTP.TabIndex = 9;
            this.lbOTP.Text = "One time pad:";
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Checked = true;
            this.rbEncrypt.Location = new System.Drawing.Point(4, 22);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(65, 19);
            this.rbEncrypt.TabIndex = 10;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(75, 22);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(66, 19);
            this.rbDecrypt.TabIndex = 11;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(12, 223);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(482, 44);
            this.btnMain.TabIndex = 12;
            this.btnMain.Text = "Encrypt";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 300);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(363, 23);
            this.txtOutput.TabIndex = 8;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(12, 279);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(48, 15);
            this.lbOutput.TabIndex = 9;
            this.lbOutput.Text = "Output:";
            // 
            // btnRandomSeed
            // 
            this.btnRandomSeed.Location = new System.Drawing.Point(381, 84);
            this.btnRandomSeed.Name = "btnRandomSeed";
            this.btnRandomSeed.Size = new System.Drawing.Size(113, 23);
            this.btnRandomSeed.TabIndex = 13;
            this.btnRandomSeed.Text = "Random";
            this.btnRandomSeed.UseVisualStyleBackColor = true;
            this.btnRandomSeed.Click += new System.EventHandler(this.btnRandomSeed_Click);
            // 
            // btnCopyOTP
            // 
            this.btnCopyOTP.Location = new System.Drawing.Point(381, 139);
            this.btnCopyOTP.Name = "btnCopyOTP";
            this.btnCopyOTP.Size = new System.Drawing.Size(113, 23);
            this.btnCopyOTP.TabIndex = 14;
            this.btnCopyOTP.Text = "Copy";
            this.btnCopyOTP.UseVisualStyleBackColor = true;
            this.btnCopyOTP.Click += new System.EventHandler(this.btnCopyOTP_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(4, 4);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(41, 15);
            this.lblMode.TabIndex = 15;
            this.lblMode.Text = "Mode:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEncrypt);
            this.panel1.Controls.Add(this.lblMode);
            this.panel1.Controls.Add(this.rbDecrypt);
            this.panel1.Location = new System.Drawing.Point(14, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 44);
            this.panel1.TabIndex = 16;
            // 
            // btnCopyOutput
            // 
            this.btnCopyOutput.Location = new System.Drawing.Point(381, 300);
            this.btnCopyOutput.Name = "btnCopyOutput";
            this.btnCopyOutput.Size = new System.Drawing.Size(113, 23);
            this.btnCopyOutput.TabIndex = 17;
            this.btnCopyOutput.Text = "Copy";
            this.btnCopyOutput.UseVisualStyleBackColor = true;
            this.btnCopyOutput.Click += new System.EventHandler(this.btnCopyOutput_Click);
            // 
            // encryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.btnCopyOutput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopyOTP);
            this.Controls.Add(this.btnRandomSeed);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbOTP);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.lbSeed);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.txtInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 380);
            this.MinimumSize = new System.Drawing.Size(530, 380);
            this.Name = "encryptForm";
            this.ShowIcon = false;
            this.Text = "One Time Pad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbSeed;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbOTP;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btnRandomSeed;
        private System.Windows.Forms.Button btnCopyOTP;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopyOutput;
    }
}

