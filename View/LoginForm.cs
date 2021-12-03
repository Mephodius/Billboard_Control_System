using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billboards
{
    public partial class LoginForm : Form
    {
        private StartForm prevForm;
        private MapBillboardForm userBillboardForm;
        public LoginForm(StartForm previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userBillboardForm = new MapBillboardForm(prevForm, false);
            userBillboardForm.Show();
            this.Visible = false;
        }
    }
}
