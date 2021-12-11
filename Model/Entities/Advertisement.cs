using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    class Advertisement
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        // место в очереди
        public int position { get; set; }
        public int size { get; set; }
        public string status { get; set; }

        public Advertisement()
        {

        }
    }
}
