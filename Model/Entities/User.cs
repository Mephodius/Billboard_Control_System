using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    class User
    {
        private string nickName;
        public ArrayList billboards = new ArrayList();
        public User(string nickName)
        {
            this.nickName = nickName;
            billboards = new ArrayList();
        }
    }
}
