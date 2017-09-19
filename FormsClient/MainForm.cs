using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listUsersBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var resp = client.GetAsync("http://localhost:50039/api/Users").Result;
            if (resp.IsSuccessStatusCode)
            {
                var stream = resp.Content.ReadAsStreamAsync().Result;
                using (stream)
                using (var reader = new StreamReader(stream))
                {
                    string input = reader.ReadToEnd();
                    var users = JsonConvert.DeserializeObject<List<ClientUser>>(input);
                    userList.Items.AddRange(users.ToArray());
                    MessageBox.Show("List OK: " + users.Count);
                }
            }
            else
            {
                MessageBox.Show("List failed!");
            }
        }
    }
}
