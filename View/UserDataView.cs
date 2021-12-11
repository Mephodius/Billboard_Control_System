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
    public partial class UserDataView : Form
    {
        AdminControlView prevForm;
        private string userNamesFilePath = System.IO.Path.Combine(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "") + "\\Resources\\usernames.txt";
        public UserDataView(AdminControlView previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
        }

        private void UsersInfoView_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(userNamesFilePath, System.Text.Encoding.Default))
            {
                string[] temp;
                string line;
                int counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    temp = line.Split(' ');
                    userDataGridView.Rows.Add();
                    userDataGridView.Rows[counter].Cells[0].Value = temp[counter];
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveUserInfo();
        }

        private void UsersInfoView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userDataGridView.RowCount > 0)
                    foreach (DataGridViewRow row in userDataGridView.SelectedRows)
                        userDataGridView.Rows.RemoveAt(row.Index);
            }
            catch{}
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)userDataGridView.Rows[0].Clone();
            userDataGridView.Rows.Add(row);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {

            if (userDataGridView.CurrentCell.ColumnIndex==0 && userDataGridView.Rows[userDataGridView.CurrentCell.RowIndex].Cells[0].Value!=null) {
                prevForm.setUserName(userDataGridView.Rows[userDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                saveUserInfo();
                this.Hide();
            }
        }
        private void saveUserInfo()
        {
            File.WriteAllText(userNamesFilePath, string.Empty);
            for(int i = 0; i < userDataGridView.RowCount-1; i++)
            {
                using (StreamWriter sw = new StreamWriter(userNamesFilePath, true))
                {
                    sw.WriteLine(userDataGridView.Rows[i].Cells[0].Value.ToString() + " ");
                }
            }
        }
    }
}
