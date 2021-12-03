using System;
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
        private string Status;
        private DataFrame timeTable;
        public Billboard(Point coord)
        {
            this.coordinates = coord;
        }
    }
}
