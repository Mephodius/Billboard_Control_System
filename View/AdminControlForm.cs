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
    public partial class AdminControlForm : Form
    {
        MapBillboardForm previousForm;
        public AdminControlForm(MapBillboardForm prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
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
    }
}
