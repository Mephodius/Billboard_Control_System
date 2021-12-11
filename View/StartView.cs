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
    public partial class StartView : Form
    {
        private MapView userBillboardForm;
        private UserLoginView loginForm;
        public StartView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            loginForm = new UserLoginView(this);
            loginForm.Show();
            this.Visible = false;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            userBillboardForm = new MapView(this, true);
            userBillboardForm.Show();
            this.Visible = false;
        }
    }
}
