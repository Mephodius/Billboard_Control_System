using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        Image mapImage;
        StartForm prevForm;
        UserControlForm userCtrlForm;
        AdminControlForm adminCtrlForm;
        AdvertisementsTable adTable;
        adVideoPlayer adPlayer;
        string slnPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "");
        Pen selectionPen = new Pen(System.Drawing.Color.Black, 4);
        Brush brush = new SolidBrush(Color.Orange);
        //классная, но бесполезная штука
        Brush gradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(1000, 1000), Color.Purple, Color.Blue);
        int bbRadius=10;
        int extendedRadius=15;
        int frequency=0; //Canvas retfresh counter for MouseMove
        private ArrayList billboardsList = new ArrayList();
        private ArrayList billboardsToDelete = new ArrayList();
        private Rectangle selectionRect = new Rectangle();
        private Point rectStartPoint;
        private Point rectEndPoint;
        private bool rectStartFlag = false;
        private string userName;
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
            RepaintMap();
        }

        private void UserBillboard_Load(object sender, EventArgs e)
        {
            loadBillboardsPosition();
        }

        private void UserBillboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!userFlag)
            {
                userCtrlForm.Close();
            }
            else
            {
                adminCtrlForm.Close();
                saveBillboardsPosition();
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

        private void MapBillboardForm_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (userFlag) {
                if (adminCtrlForm.AddBillboardFlag)
                {
                    frequency++;
                    Rectangle rect = new Rectangle(PointToClient(Cursor.Position).X - bbPointRadius, PointToClient(Cursor.Position).Y - bbPointRadius, bbPointRadius*2, bbPointRadius * 2);
                    g.FillEllipse(brush, rect);
                    if ((frequency%3)==0) {
                        RepaintMap();
                    }
                }
            }*/
            if (!userFlag||!adminCtrlForm.AddBillboardFlag)
            {
                if (rectStartFlag && e.Button == MouseButtons.Left) {
                    rectEndPoint = e.Location;
                    selectionRect.Location = new Point(
                        Math.Min(rectStartPoint.X, rectEndPoint.X),
                        Math.Min(rectStartPoint.Y, rectEndPoint.Y));
                    selectionRect.Size = new Size(
                        Math.Abs(rectStartPoint.X - rectEndPoint.X),
                        Math.Abs(rectStartPoint.Y - rectEndPoint.Y));
                    g.DrawRectangle(selectionPen, selectionRect);
                    frequency++;
                    if ((frequency % 5) == 0)
                    {
                        this.Invalidate();
                    }
                }
                else
                {
                    if (!userFlag||!adminCtrlForm.getDeleteBillBoardButton().Enabled) {
                        Billboard closestBillboard = getClosest(e);
                        if (closestBillboard!=null)
                        {
                            if (g != null)
                            {
                                Rectangle rect = new Rectangle(closestBillboard.Coordinates.X - extendedRadius, closestBillboard.Coordinates.Y - extendedRadius, extendedRadius * 2, extendedRadius * 2);
                                g.FillEllipse(gradientBrush, rect);
                            }
                        }
                        frequency++;
                        if ((frequency % 10) == 0)
                        {
                            this.Invalidate();
                        }
                    }
                }
            }
        }

        private void MapBillboardForm_MouseHover(object sender, EventArgs e)
        {
            if (userFlag)
            {
                if (adminCtrlForm.AddBillboardFlag)
                {
                    /*
                    Rectangle rect = new Rectangle(PointToClient(Cursor.Position).X-bbPointRadius, PointToClient(Cursor.Position).Y - bbPointRadius, bbPointRadius * 2, bbPointRadius * 2);
                    g.FillEllipse(brush, rect);
                    */
                }
            }
        }

        private void MapBillboardForm_MouseClick(object sender, MouseEventArgs e)
        {
            Billboard closestBillboard = getClosest(e);
            if (userFlag)
            {
                if (adminCtrlForm.AddBillboardFlag)
                {
                    int bbX = PointToClient(Cursor.Position).X - bbRadius;
                    int bbY = PointToClient(Cursor.Position).Y - bbRadius;
                    Rectangle rect = new Rectangle(bbX, bbY, bbRadius * 2, bbRadius * 2);
                    g.FillEllipse(brush, rect);
                    adminCtrlForm.AddBillboardFlag = false;
                    adminCtrlForm.getAddBillBoardButton().Enabled = true;
                    //Point хранит координаты центра билборда
                    billboardsList.Add(new Billboard(new Point(bbX+bbRadius, bbY+ bbRadius), adminCtrlForm.SelectedUserName));

                    Cursor = Cursors.Default;
                }
            }
            if (closestBillboard != null)
            {
                adTable = new AdvertisementsTable();
                adTable.Show();
                //вывести таблицу DataGridView: id видео, название видео, очередность, размер, текущее состояние(воспроизводится, будет воспроизведено, ожидает файла)
            }
        }

        public void RepaintMap()
        {
            mapImage = Image.FromFile(slnPath + "\\Resources\\Minsk.png");
            g.DrawImage(mapImage, 0, 0, this.Width, this.Height);
            if (userFlag)
            {
                foreach (Billboard billboard in billboardsList)
                {
                    Rectangle rect = new Rectangle(billboard.Coordinates.X - bbRadius, billboard.Coordinates.Y - bbRadius, bbRadius * 2, bbRadius * 2);
                    g.FillEllipse(brush, rect);
                }
            }
            else
            {
                foreach (Billboard billboard in billboardsList)
                {
                    if (billboard.Owner==userName) {
                        Rectangle rect = new Rectangle(billboard.Coordinates.X - bbRadius, billboard.Coordinates.Y - bbRadius, bbRadius * 2, bbRadius * 2);
                        g.FillEllipse(brush, rect);
                    }
                }
            }
        }

        private void MapBillboardForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left&&(!userFlag||!adminCtrlForm.AddBillboardFlag))
            {
                rectStartPoint = e.Location;
                rectStartFlag = true;
                billboardsToDelete = new ArrayList();
            }
        }

        private void MapBillboardForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && rectStartFlag==true && userFlag)
            {
                bool emptyFlag = true;
                int counter = 0;
                rectStartFlag = false;
                foreach (Billboard billboard in billboardsList)
                {
                    if ((billboard.Coordinates.X - bbRadius > rectStartPoint.X) && (billboard.Coordinates.X - bbRadius < rectEndPoint.X)) {
                        if ((billboard.Coordinates.Y - bbRadius > rectStartPoint.Y) && (billboard.Coordinates.Y - bbRadius < rectEndPoint.Y)) {
                            emptyFlag = false;
                            billboardsToDelete.Add(counter);
                            Rectangle rect = new Rectangle(billboard.Coordinates.X - extendedRadius, billboard.Coordinates.Y-extendedRadius, extendedRadius * 2, extendedRadius * 2);
                            g.FillEllipse(gradientBrush, rect);
                        }
                    }
                    counter++;
                }
                if (!emptyFlag)
                {
                    adminCtrlForm.getDeleteBillBoardButton().Enabled = true;
                }
            }
        }
        public ArrayList getBillboardList()
        {
            return this.billboardsList;
        }
        public ArrayList getBillBoardsToDelete()
        {
            return this.billboardsToDelete;
        }
        private Billboard getClosest(MouseEventArgs e)
        {
            double hypot = 0;
            double besthypot = 100;
            Billboard closestBillboard = null;
            foreach (Billboard billboard in billboardsList)
            {
                hypot = Math.Sqrt(Math.Pow(billboard.Coordinates.X - e.Location.X, 2) + Math.Pow(billboard.Coordinates.Y - e.Location.Y, 2));
                if ((hypot < extendedRadius * 2) && (hypot < besthypot))
                {
                    closestBillboard = billboard;
                    besthypot = hypot;
                }
            }
            return closestBillboard;
        }

        private void MapBillboardForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Billboard closestBillboard = getClosest(e);
            if (closestBillboard != null)
            {
                //проиграть видео
                adTable.Close();
                adPlayer = new adVideoPlayer(slnPath);
                adPlayer.Show();
            }
        }
        public void getUserName(string userName)
        {
            this.userName = userName;
            userCtrlForm.UserName=this.userName;
        }
        private void saveBillboardsPosition()
        {
            string path = slnPath + "\\Resources\\aboba.txt";
            System.IO.File.WriteAllBytes(path, new byte[0]);
            foreach (Billboard billboard in billboardsList)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(billboard.Owner + " " + billboard.Coordinates.X + " " + billboard.Coordinates.Y);
                }
            }
        }
        private void loadBillboardsPosition()
        {
            string path = slnPath + "\\Resources\\aboba.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string[] temp;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp = line.Split(' ');
                    if (userFlag||temp[0].Equals(userName)) {
                        billboardsList.Add(new Billboard(new Point(Int32.Parse(temp[1]), Int32.Parse(temp[2])), temp[0]));
                    }
                }
            }
        }
    }
}
