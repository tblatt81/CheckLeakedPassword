using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckLeakedPassword
{
    public partial class CheckLeakedPassword : Form
    {
        public CheckLeakedPassword()
        {
            InitializeComponent();

            label4.BackColor = System.Drawing.Color.Transparent;

            textBoxPassword.KeyDown += TextBoxPassword_KeyDown;
            checkBoxHidePassword.CheckedChanged += CheckBoxHidePassword_CheckedChanged;
        }

        private void CheckBoxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHidePassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCheckAtPwnedPasswords_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true; // Suppress system beep
            }
        }

        private void buttonCheckAtPwnedPasswords_Click(object sender, EventArgs e)
        {
            buttonResult.BackColor = SystemColors.Control;
            buttonResult.Text = "";

            var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));
            StringBuilder sha1Result = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                sha1Result.AppendFormat("{0:x2}", b);
            }
            labelSHA1.Text = sha1Result.ToString().ToUpper();

            CallPwnedPasswordsApi(sha1Result);
        }

        /// <summary>
        /// API at PwnedPsswords.com is called with first 5 chars of SHA1-hash
        /// Result hashes are searched through for original hash
        /// </summary>
        private void CallPwnedPasswordsApi(StringBuilder sha1Result)
        {
            string first5Chars = sha1Result.ToString(0, 5); // Only the first 5 chars are send to the API
            string last35Chars = sha1Result.ToString(5, sha1Result.Length - 5); // results of API call only contain last 35 chars of hash

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(new Uri(new Uri("https://api.pwnedpasswords.com/range/"), first5Chars));
            string response = restClient.Execute<string>(restRequest).Content.ToString();
            string[] separators = new string[] { "\r\n" };
            var hashes = response.Split(separators, StringSplitOptions.None);

            bool leaked = false;
            foreach (string hash in hashes)
            {
                string newHash = hash.Substring(0, hash.IndexOf(":"));
                int numberOfOccurrences = Convert.ToInt32(hash.Substring(hash.IndexOf(":") + 1));
                if (newHash.ToLower() == last35Chars.ToLower())
                {
                    buttonResult.BackColor = Color.Red;
                    buttonResult.Text = "Password is leaked";
                    labelNumberOccurrences.Text = numberOfOccurrences.ToString("N0");
                    leaked = true;
                }
            }

            if (!leaked)
            {
                buttonResult.BackColor = Color.Green;
                buttonResult.Text = "Password is NOT leaked";
                labelNumberOccurrences.Text = "0";
            }
        }
    }
}
