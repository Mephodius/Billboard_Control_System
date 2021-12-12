using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Presenter.Presenters;

namespace View
{
    public partial class ScheduleUpdateView : Form, ISheduleUpdateView
    {
        SUVPresenter suvpresenter;
        public ScheduleUpdateView()
        {
            suvpresenter = new SUVPresenter(this);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void CreateScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)createScheduleDataGridView.Rows[0].Clone();
            createScheduleDataGridView.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (createScheduleDataGridView.RowCount > 0)
                    foreach (DataGridViewRow row in createScheduleDataGridView.SelectedRows)
                        createScheduleDataGridView.Rows.RemoveAt(row.Index);
            }
            catch{}
        }
    }
}
