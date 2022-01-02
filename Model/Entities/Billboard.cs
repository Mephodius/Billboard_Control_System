using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Billboard
    {
        public int id { get; set; }
        public Point coordinates { get; set; }//top left coordinate
        /*available - green
          waiting_for_data - orange
          stopped_working - red
        */
        public string status { get; set; }
        public AdQueue adQueue;
        public int group { get; set; }
        Thread thread;
        public string owner { get; set; }
        public int capacity { get; set; }
        public int adNum { get; set; }
        public Billboard(Point coord, string user, int capacity)
        {
            this.group = -1;
            this.status = "available";
            this.coordinates = coord;
            this.owner = user;
            this.capacity = capacity;
            this.adNum = 0;
        }
    }
}
