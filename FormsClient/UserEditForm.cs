using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsClient
{
    public partial class UserEditForm : Form
    {
        public ClientUser User { get; set; }

        public UserEditForm()
        {
            InitializeComponent();
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            idTxt.Text = User.Id.ToString();
            nameTxt.Text = User.Name;
            ageNum.Value = User.Age;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            User.Name = nameTxt.Text;
            User.Age = (int)ageNum.Value;
        }
    }
}
