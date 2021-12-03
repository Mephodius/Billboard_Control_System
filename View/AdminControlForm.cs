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
    public partial class AdminControlForm : Form
    {
        MapBillboardForm previousForm;
        UsersInfoView usersInfoView;
        public AdminControlForm(MapBillboardForm prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
            usersInfoView = new UsersInfoView(this);
        }

        private void AdminControlForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            previousForm.getShowOptionsButton().Visible = true;
            this.Visible = false;
        }

        private void AdminControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            previousForm.getShowOptionsButton().Visible = true;
            this.Visible = false;
        }

        private void showUsersButton_Click(object sender, EventArgs e)
        {
            usersInfoView.Show();
        }

        private void addBillboardButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteBillboardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
