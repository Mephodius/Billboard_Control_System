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
    public partial class UserControlForm : Form
    {
        private OpenFileDialog openAd;
        private MapBillboardForm prevForm;
        private ShowInfoForm showInfForm;
        private CreateScheduleForm createSchForm;
        public UserControlForm(MapBillboardForm previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
            showInfForm = new ShowInfoForm();
            createSchForm = new CreateScheduleForm();
            openAd = new OpenFileDialog();
            openAd.Filter = "Image files(*.jpg)|*.jpg|All files(*.*)|*.*";
            uniteButton.Enabled = false;
            TopMost = true;
        }

        private void AddAdButton_Click(object sender, EventArgs e)
        {
            if (openAd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openAd.FileName;
        }

        private void UserControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.getShowOptionsButton().Visible = true;
            e.Cancel=true;
            this.Visible = false;
        }

        private void UserControlForm_Load(object sender, EventArgs e)
        {

        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            showInfForm.Show();
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            prevForm.getShowOptionsButton().Visible = true;
            this.Visible = false;
        }

        private void createScheduleButton_Click(object sender, EventArgs e)
        {
            createSchForm.Show();
        }
    }
}
