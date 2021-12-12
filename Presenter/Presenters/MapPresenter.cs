using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

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
    }
}
