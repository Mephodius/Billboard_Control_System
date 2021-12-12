using System;
using System.Collections;
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
    public partial class DeviceSheduleView : Form, IDeviceSheduleView
    {
        ArrayList advertisments;
        DSVPresenter dsvpresenter;
        public DeviceSheduleView()
        {
            dsvpresenter = new DSVPresenter(this);
            InitializeComponent();
        }
        
        public void SheduleTable_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
