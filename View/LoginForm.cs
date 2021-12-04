using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class LoginForm : Form
    {
        private StartForm prevForm;
        private MapBillboardForm mapBillboardForm;
        private string userNamesFilePath = System.IO.Path.Combine(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "") + "\\Resources\\usernames.txt";
        public LoginForm(StartForm previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(userNamesFilePath, System.Text.Encoding.Default))
            {
                string[] temp;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp = line.Split(' ');
                    if (temp[0].Equals(userNameTextBox.Text))
                    {
                        mapBillboardForm = new MapBillboardForm(prevForm, false);
                        mapBillboardForm.getUserName(userNameTextBox.Text);
                        mapBillboardForm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Please, enter correct username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            prevForm.Show();
        }
    }
}
