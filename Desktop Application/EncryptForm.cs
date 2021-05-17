using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sig
{
    public partial class encryptForm : Form
    {
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

        private byte[] OTPFromSeed(Encoding encode)
        {
            if (txtSeed.Text.Length == 0 && txtOTP.Text.Length > 0)
            {
                return encode.GetBytes(txtOTP.Text);
            }
            bool isNumeric = int.TryParse(txtSeed.Text, out _);
            byte[] oneTimePad;
            if (isNumeric)
                oneTimePad = OneTimePad.GenerateOTP(int.Parse(txtSeed.Text), txtInput.Text.Length);
            else
                oneTimePad = OneTimePad.GenerateOTP(txtSeed.Text, txtInput.Text.Length);

            return oneTimePad;
        }


        private void InputToOutput(Encoding encode)
        {
            if (rbEncrypt.Checked)
            {
                byte[] inputText = encode.GetBytes(txtInput.Text);
                byte[] oneTimePad = OTPFromSeed(encode);

                txtOTP.Text = encode.GetString(oneTimePad);
                txtOutput.Text = encode.GetString(OneTimePad.Encrypt(oneTimePad, inputText));
            }
            else
            {
                byte[] inputText = encode.GetBytes(txtInput.Text);
                byte[] oneTimePad = encode.GetBytes(txtOTP.Text);

                txtOutput.Text = encode.GetString(OneTimePad.Decrypt(inputText, oneTimePad));
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
