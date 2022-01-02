using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter.Presenters
{
    public class UserLoginPresenter
    {
        IUserLoginView ulogin;
        BBControlSystem system;
        public UserLoginPresenter(IUserLoginView ulogin)
        {
            this.ulogin = ulogin;
            this.system = BBControlSystem.getInstance();
        }
        public bool IsUser(string name)
        {
            
            if (system.getServer().isUser(name).Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
