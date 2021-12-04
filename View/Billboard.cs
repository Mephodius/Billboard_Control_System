using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Analysis;

namespace View
{
    class Billboard
    {
        private Point coordinates;//top left coordinate
        public Point Coordinates {
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
        private DataFrame timeTable;
        private string owner;
        private int group;
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        ArrayList adverstisementsPaths;
        public Billboard(Point coord, string ownerName)
        {
            this.coordinates = coord;
            this.owner = ownerName;
        }
    }
}
