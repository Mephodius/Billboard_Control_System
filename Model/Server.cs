using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private SqlConnection BBConnection = null;
        private SqlConnection UserConnection = null;
        private Server()
        {
            //Console.WriteLine(ConfigurationManager.ConnectionStrings["Billboards"].ConnectionString);
            BBConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\PT1\\Billboard_Control_System\\Model\\BillbardsDB.mdf; Integrated Security = True");
            BBConnection.Open();
            UserConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\PT1\\Billboard_Control_System\\Model\\UsersDB.mdf; Integrated Security = True");
            UserConnection.Open();
        }

        public static Server getInstance()
        {
            if (server == null)
                 server = new Server();
            return server;
        }

        //private string project_path;
        //private string billboard_data_path;
        //private string user_data_path;
        private string advertisement_path;
        //private string system_files_data_path;
      
        public DataSet getUsers(string command = "SELECT * FROM Users")
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, UserConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
        public DataSet getBillboards(string command = "SELECT * FROM Billboards")
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, BBConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
        public DataSet getAdvertisements(string command = "SELECT * FROM Ads")
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, BBConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
        public DataSet getLogs(string command = "SELECT * FROM Logs")
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, UserConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
        public void loadMedia(string destpath, string command = "SELECT * FROM Ads")
        {
            // Загружает данные с сервера на билборды
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, BBConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            foreach (DataRow ad in dataSet.Tables[0].Rows)
            {
                try
                {
                    File.Copy(Convert.ToString(ad["AdPath"]),destpath,true);
                }
                catch (IOException iox)
                {
                }
            }
        }
        public void setUsers(DataTable dataSet)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * Users", UserConnection);
            sqlDataAdapter.Update(dataSet);
        }
        public void setBillboards(DataSet dataSet)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Billboards", BBConnection);
            sqlDataAdapter.Update(dataSet);
        }
        public void setLogs(DataSet dataSet)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Logs", UserConnection);
            sqlDataAdapter.Update(dataSet);
        }
        public void setAdvertisements(DataSet dataSet)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Ads", BBConnection);
            sqlDataAdapter.Update(dataSet);
        }
        public void uploadMedia(string source_file_path)
        {
            try
            {
                File.Copy(source_file_path, advertisement_path, true);
            }
            catch (IOException iox)
            {
            }
        }
        public int addBillboard(Billboard billboard)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Billboards] VALUES (@Owner, @Group, @X, @Y, @Status, @CapacityLeft, @AdNum)", BBConnection);
            command.Parameters.AddWithValue("@Owner", billboard.owner);
            command.Parameters.AddWithValue("@Group", billboard.group);
            command.Parameters.AddWithValue("@X", billboard.coordinates.X);
            command.Parameters.AddWithValue("@Y", billboard.coordinates.Y);
            command.Parameters.AddWithValue("@Status", billboard.status);
            command.Parameters.AddWithValue("@CapacityLeft", billboard.capacity);
            command.Parameters.AddWithValue("@AdNum", billboard.adNum);
            command.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("SELECT MAX(id) FROM Users", UserConnection);
            int id = command1.ExecuteNonQuery();
            return id;
        }
        public int addUser(User user)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Users] VALUES (@Name, @RegTime, @BillboardNum, @Status)", UserConnection);
            command.Parameters.AddWithValue("@Name", user.name);
            command.Parameters.AddWithValue("@RegTime", user.regTime);
            command.Parameters.AddWithValue("@BillboardNum", user.bbNum);
            command.Parameters.AddWithValue("@Status", user.status);
            command.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("SELECT MAX(id) FROM Users", UserConnection);
            int id = command1.ExecuteNonQuery();
            return id;
        }
        public void deleteUser(int id)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Users WHERE Id = '{id}'", UserConnection);
            command.ExecuteNonQuery();
        }
        public void deleteBillboard(int id)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Billboards WHERE Id = '{id}'", BBConnection);
            command.ExecuteNonQuery();
        }
        public DataSet isUser(string name)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT Name FROM Users WHERE Name = '{name}'", UserConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
