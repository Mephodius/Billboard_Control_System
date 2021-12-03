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
    public partial class MapBillboardForm : Form
    {
        bool userFlag;
        private Graphics g;
        Image img;
        StartForm prevForm;
        UserControlForm userCtrlForm;
        AdminControlForm adminCtrlForm;
        string slnPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "");

        Pen myPen = new Pen(System.Drawing.Color.Red, 5);
        public MapBillboardForm(StartForm previousForm, bool userFlg)
        {
            InitializeComponent();
            this.userFlag = userFlg;
            showOptionsButton.Visible = false;
            if (this.userFlag == false)
            {
                userCtrlForm = new UserControlForm(this);
                userCtrlForm.Show();
            }
            else
            {
                adminCtrlForm = new AdminControlForm(this);
                adminCtrlForm.Show();
            }
            prevForm = previousForm;
            this.Paint += new PaintEventHandler(UserBillboard_Paint);

        }

        private void UserBillboard_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            img = Image.FromFile(slnPath+ "\\Resources\\Minsk.png");
            g.DrawImage(img, 0, 0, this.Width, this.Height);
        }

        private void UserBillboard_Load(object sender, EventArgs e)
        {

        }

        private void UserBillboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.userFlag == false)
            {
                userCtrlForm.Close();
            }
            else
            {
                adminCtrlForm.Close();
            }
            prevForm.Visible = true;
        }

        private void showOptionsButton_Click(object sender, EventArgs e)
        {
            if (this.userFlag)
            {
                adminCtrlForm.Show();
            }
            else
            {
                userCtrlForm.Show();
            }
            showOptionsButton.Visible = false;
        }

        private void changeComponentVisibility<Component>(Component comp) where Component:Control
        {
            if (comp.Visible)
            {
                comp.Visible = false;
            }
            else
            {
                comp.Visible = true;
            }
        }
        public Control getShowOptionsButton()
        {
            return this.showOptionsButton;
        }

    }
}
