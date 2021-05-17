using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneTimePad;


namespace Sig
{
    public partial class encryptForm : Form
    {

        OneTimePadAlgorithm otp;
        public encryptForm()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true)
            {
                btnMain.Text = rb.Text;
            }

            bool enableRandomSeed = true;
            if (rbDecrypt.Checked)
            {
                enableRandomSeed = false;
            }

            lbSeed.Enabled = enableRandomSeed;
            txtSeed.Enabled = enableRandomSeed;
            btnRandomSeed.Enabled = enableRandomSeed;
        }

        private void btnRandomSeed_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            txtSeed.Text = rand.Next() + "";
        }


        private void InputToOutput(Encoding encode)
        {
            otp = OneTimePadAlgorithm.Create();
            otp.setInputLength(txtInput.Text.Length);
            if (rbEncrypt.Checked)
            {

                bool isNumeric = int.TryParse(txtSeed.Text, out _);
                if (isNumeric)
                    otp.setStringSeed(int.Parse(txtSeed.Text));
                else
                    otp.setStringSeed(txtSeed.Text);

                otp.GenerateKey();
                CryptoTransform ict = (CryptoTransform)otp.CreateEncryptor(otp.Key,null);


                byte[] inputText = encode.GetBytes(txtInput.Text);
            
                txtOTP.Text = encode.GetString(otp.Key);
                txtOutput.Text = encode.GetString(ict.TransformFinalBlock(inputText, 0, txtInput.Text.Length));
            }
            else
            {
                otp.Key = encode.GetBytes(txtOTP.Text);
                CryptoTransform ict = (CryptoTransform)otp.CreateDecryptor(otp.Key, null);

                byte[] inputText = encode.GetBytes(txtInput.Text);


                txtOutput.Text = encode.GetString(ict.TransformFinalBlock(inputText, 0, txtInput.Text.Length));
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            InputToOutput(Encoding.GetEncoding("ISO-8859-1"));
        }

        private void btnCopyOTP_Click(object sender, EventArgs e)
        {
            if(txtOTP.Text.Length > 0)
                Clipboard.SetText(txtOTP.Text);
        }

        private void btnCopyOutput_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text.Length > 0)
                Clipboard.SetText(txtOutput.Text);
        }

    }
}
