using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model
{
    // класс - одиночка
    public class Server
    {
        private static Server server;

        private Server()
        { }

        public static Server getInstance()
        {
            if (server == null)
                 server = new Server();
            return server;
        }

        private string project_path;
        private string billboard_data_path;
        private string user_data_path;
        private string advertisement_path;
        private string system_files_data_path;
      
        public ArrayList getUserList()
        {
            return new ArrayList();
        }
        public ArrayList getBillboardList(User user)
        {
            if (user == null)
            {
                // считать все билборды т.к админ
            }
            else
            {
                // считать только билборды этого юзера
            }
            return new ArrayList();
        }
        public ArrayList getSystemData()
        {
            return new ArrayList();
        }
        public void getAdvertisements(ArrayList adnames, string destpath)
        {
            // copy files to the billboard storage (destpath)
        }
        public void setUserList(ArrayList userlist)
        {
            // загрузить переданные данные в соответствующую папочку
        }
        public void setBillboardList(ArrayList billboardlist)
        {
            // загрузить переданные данные в соответствующую папочку
        }
        public void addMedia(string source_file_path)
        {
            try
            {
                File.Copy(source_file_path, advertisement_path, true);
            }
            catch (IOException iox)
            {
            }
        }

    }
}
