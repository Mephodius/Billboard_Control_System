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
    public partial class UsersInfoView : Form
    {
        AdminControlForm prevForm;
        public UsersInfoView(AdminControlForm previousForm)
        {
            InitializeComponent();
            prevForm = previousForm;
        }

        private void UsersInfoView_Load(object sender, EventArgs e)
        {

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

        }
    }
}
