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
using Presenter;
using Presenter.Presenters;
using Model.Entities;
using Microsoft.VisualBasic;

namespace View
{
    public partial class UserDataView : Form, IUserDataView
    {
        UserDataPresenter userpresenter;
        AdminControlView prevForm;
        private string userNamesFilePath = System.IO.Path.Combine(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "") + "\\Resources\\usernames.txt";
        public UserDataView(AdminControlView previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
            userpresenter = new UserDataPresenter(this);
        }

        private void UsersInfoView_Load(object sender, EventArgs e)
        {
            //using (StreamReader sr = new StreamReader(userNamesFilePath, System.Text.Encoding.Default))
            //{
            //string[] temp;
            //string line;
            //int counter = 0;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    temp = line.Split(' ');
            //    userDataGridView.Rows.Add();
            //    userDataGridView.Rows[counter].Cells[0].Value = temp[counter];
            //}
            //DataSet ds = userpresenter.getUsers();
            //foreach (DataRow user in ds.Tables[0].Rows)
            //{
            //    userDataGridView.Rows.Add(user);   
            //
            //}
            userDataGridView.DataSource = userpresenter.getUsers().Tables[0];
            //userDataGridView.Columns["id"].Visible = true;
            userDataGridView.Refresh();
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersInfoView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (userDataGridView.RowCount > 0)
            //        foreach (DataGridViewRow row in userDataGridView.SelectedRows)
            //            userDataGridView.Rows.RemoveAt(row.Index);
            //}
            //catch{}
            string id = Interaction.InputBox("Enter the id", "User delete");
            userpresenter.deleteUser(Int32.Parse(id));
            userDataGridView.DataSource = userpresenter.getUsers().Tables[0];


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = (DataGridViewRow)userDataGridView.Rows[0].Clone();
            //userDataGridView.Rows.Add(row);
            this.SendToBack();
            string name = Interaction.InputBox("What user to select", "User selection");
            User user = new User(name);
            userpresenter.addUser(user);
            userDataGridView.DataSource = userpresenter.getUsers().Tables[0];
            //userDataGridView.Refresh();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {

            prevForm.setUserName(Interaction.InputBox("What user to select", "User selection"));
            this.Hide();
            //if (userDataGridView.CurrentCell.ColumnIndex==0 && userDataGridView.Rows[userDataGridView.CurrentCell.RowIndex].Cells[0].Value!=null) {
            //    prevForm.setUserName(userDataGridView.Rows[userDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //    saveUserInfo();
            //    this.Hide();
            //}
        }

        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            userDataGridView.ClearSelection();
        }
    }
}
