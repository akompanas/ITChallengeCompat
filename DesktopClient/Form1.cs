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

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        public Form1() { 
            InitializeComponent();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var resp = client.GetAsync("http://localhost:50039/api/Users").Result;
            if (resp.IsSuccessStatusCode)
            {
                string json = resp.Content.ReadAsStringAsync().Result;
                List<ClientUser> users = JsonConvert.DeserializeObject<List<ClientUser>>(json);
                userListBox.Items.AddRange(users.ToArray());
                //MessageBox.Show("Success! " + users.Count);
            }
            else
                MessageBox.Show("Failure");
        }
    }
}
