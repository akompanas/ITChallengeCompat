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
            ListUsers();
        }

        private void ListUsers()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var resp = client.GetAsync("http://localhost:50039/api/Users").Result;
            if (resp.IsSuccessStatusCode)
            {
                string json = resp.Content.ReadAsStringAsync().Result;
                List<ClientUser> users = JsonConvert.DeserializeObject<List<ClientUser>>(json);
                userListBox.Items.Clear();
                userListBox.Items.AddRange(users.ToArray());
                //MessageBox.Show("Success! " + users.Count);
            }
            else
                MessageBox.Show("Failure");
        }

        private void userListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var user = (ClientUser)userListBox.SelectedItem;
            if (user == null)
                return;

            var editForm = new UserEditForm();
            editForm.User = user;
            if (editForm.ShowDialog(this) != DialogResult.OK)
                return;

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            var resp = client.PostAsync("http://localhost:50039/api/Users", content).Result;
            if (resp.IsSuccessStatusCode)
            {
                ListUsers();
            }
            else
            {
                MessageBox.Show("Error: " + resp);
            }
        }
    }
}
