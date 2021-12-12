using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter.Presenters
{
    public class DSVPresenter
    {
        IDeviceSheduleView deviceSheduleView;
        BBControlSystem system;
        public DSVPresenter(IDeviceSheduleView deviceSheduleView)
        {
            this.deviceSheduleView = deviceSheduleView;
            this.system = BBControlSystem.getInstance();
            //deviceSheduleView.SheduleTable_Load();
        }
    }
}
