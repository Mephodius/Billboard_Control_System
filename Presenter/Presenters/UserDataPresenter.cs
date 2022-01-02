using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entities;
namespace Presenter.Presenters
{
    public class UserDataPresenter
    {
        IUserDataView udataview;
        BBControlSystem system;
        public UserDataPresenter(IUserDataView udataview)
        {
            this.udataview = udataview;
            this.system = BBControlSystem.getInstance();
        }
        public DataSet getUsers()
        {
            return system.getServer().getUsers();
        }
        public void setUsers(DataTable ds)
        {
            system.getServer().setUsers(ds);
        }
        public void addUser(User user)
        {
            system.getServer().addUser(user);
        }
        public void deleteUser(int id)
        {
            system.getServer().deleteUser(id);
        }
    }
}
