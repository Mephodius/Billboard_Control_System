using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public LoginForm(StartForm previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mapBillboardForm = new MapBillboardForm(prevForm, false);
            mapBillboardForm.getUserName(userNameTextBox.Text);
            mapBillboardForm.Show();
            this.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
