using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using Model;
using System.Data;

namespace Presenter.Presenters
{
    public class MapPresenter
    {
        IMapView map;
        BBControlSystem system;
        public MapPresenter(IMapView map)
        {
            this.map = map;
            this.system = BBControlSystem.getInstance();
        }
        public int addBillboard(Billboard billboard)
        {
            return system.getServer().addBillboard(billboard);
        }
        public DataSet getBillboards()
        {
            return system.getServer().getBillboards();
        }
        public void deleteBillboard(Billboard billboard)
        {
            system.getServer().deleteBillboard(billboard.id);
        }
    }
}
