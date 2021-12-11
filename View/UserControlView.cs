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
    public partial class UserControlView : Form
    {
        private OpenFileDialog openAd;
        private MapView prevForm;
        private BillboardDataView showInfForm;
        private ScheduleUpdateView createSchForm;
        string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                this.Text = userName;
            }
        }
        public UserControlView(MapView previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
            showInfForm = new BillboardDataView();
            createSchForm = new ScheduleUpdateView();
            openAd = new OpenFileDialog();
            openAd.Filter = "Image files(*.jpg)|*.jpg|All files(*.*)|*.*";
            uniteButton.Enabled = false;
            TopMost = true;
            this.Text = userName;
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

        private void uniteButton_Click(object sender, EventArgs e)
        {
            uniteButton.Enabled = false;
        }
        public Control getUniteButton()
        {
            return uniteButton;
        }
    }
}
