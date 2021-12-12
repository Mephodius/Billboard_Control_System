using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Presenter.Presenters
{
    public class SUVPresenter
    {
        ISheduleUpdateView sheduleView;
        BBControlSystem system;
        public SUVPresenter(ISheduleUpdateView shedule)
        {
            this.sheduleView = shedule;
            this.system = BBControlSystem.getInstance();
        }
    }
}
