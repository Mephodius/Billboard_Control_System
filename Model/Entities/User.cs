using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public ArrayList billboards = new ArrayList();
        public DateTime regTime { get; set; }
        public int bbNum { get; set; }
        public string status { get; set; }
        public User(string nickName)
        {
            this.bbNum = 0;
            this.status = "Offline";
            this.name = nickName;
            this.regTime = DateTime.Now;
            billboards = new ArrayList();
        }
    }
}
