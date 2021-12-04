﻿using System;
using System.Collections;
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
        private bool addBillboardFlag;
        string selectedUserName;
        public bool AddBillboardFlag
        {
            get
            {
                return addBillboardFlag;
            }
            set
            {
                addBillboardFlag = value;
            }
        }
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
            addBillboardFlag = true;
            addBillboardButton.Enabled = false;
            previousForm.Cursor = Cursors.Cross;
        }

        private void deleteBillboardButton_Click(object sender, EventArgs e)
        {
            previousForm.getBillBoardsToDelete().Reverse();
            ArrayList array = previousForm.getBillBoardsToDelete();
            //for(int i = array.Count;i>=0;i--)
            foreach(int index in array)
            {
                previousForm.getBillboardList().RemoveAt(index);
            }
            previousForm.RepaintMap();
            deleteBillboardButton.Enabled = false;
        }

        public Control getAddBillBoardButton()
        {
            return this.addBillboardButton;
        }
        public Control getDeleteBillBoardButton()
        {
            return this.deleteBillboardButton;
        }

        private void showLogsButton_Click(object sender, EventArgs e)
        {

        }
        public void setUserName(string userName)
        {
            selectedUserName = userName;
        }
    }
}
