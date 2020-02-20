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
                e.SuppressKeyPress = true;
            }
        }

        private void buttonCheckAtPwnedPasswords_Click(object sender, EventArgs e)
        {
            buttonResult.BackColor = SystemColors.Control;
            buttonResult.Text = "";
            var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));
            //string a = System.Text.Encoding.Default.GetString(hash);
            //string b = hash.ToString();
            StringBuilder sha1Result = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                sha1Result.AppendFormat("{0:x2}", b);
            }
            labelSHA1.Text = sha1Result.ToString().ToUpper();

            CallPwnedPasswordsApi(sha1Result);
            

        }

        private void CallPwnedPasswordsApi(StringBuilder sha1Result)
        {
            string first5Chars = sha1Result.ToString(0, 5);
            string last5Chars = sha1Result.ToString(5, sha1Result.Length - 5);

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(new Uri(new Uri("https://api.pwnedpasswords.com/range/"), first5Chars));
            //IRestResponse restResponse = restClient.Get(restRequest);
            //List<string> response = restClient.Execute<List<string>>(restRequest).Data;
            string response2 = restClient.Execute<string>(restRequest).Content.ToString();
            string[] separators = new string[] { "\r\n" };
            var abc = response2.Split(separators, StringSplitOptions.None);

            bool leaked = false;
            foreach (string hash in abc)
            {
                string newHash = hash.Substring(0, hash.IndexOf(":"));
                if (newHash.ToLower() == last5Chars.ToLower())
                {
                    buttonResult.BackColor = Color.Red;
                    buttonResult.Text = "Password is leaked";
                    leaked = true;
                }
            }

            if (!leaked)
            {
                buttonResult.BackColor = Color.Green;
                buttonResult.Text = "Password is NOT leaked";
            }


            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(new Uri("https://api.pwnedpasswords.com/range/"), first5Chars);
            //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //    HttpResponseMessage httpResponse = client.GetAsync(client.BaseAddress).Result;
            //    if (httpResponse.IsSuccessStatusCode)
            //    {
            //        var data = httpResponse.Content.ReadAsByteArrayAsync().Result;
            //        foreach (var item in data)
            //        {

            //        }
            //    }

            //}
        }
    }
}
