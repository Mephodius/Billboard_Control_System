using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model.Entities
{
    class Billboard
    {
        private Point coordinates;//top left coordinate
        public Point Coordinates
        {
            get
            {
                return coordinates;
            }
            set
            {
                coordinates = value;
            }
        }
        /*avaiable - green
          waiting_for_data - orange
          stopped_working - red
        */
        private string status;
        public AdQueue adQueue;
        private int group;
        Thread thread;
        private string owner;
        
        public Billboard(Point coord, string user)
        {
            this.coordinates = coord;
            this.owner = user;
        }
    }
}
