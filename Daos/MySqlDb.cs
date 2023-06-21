using System.Data;
using KNN.Models;
using MySql.Data.MySqlClient;

namespace KNN.Daos
{
    public class MySqlDb : IDb
    {
        MySqlConnection con;
        public MySqlDb()
        {
            con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ag002");
        }

        public void OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<DataModel>? SelectAll()
        {
            try
            {
                var cmd = new MySqlCommand("SELECT * FROM `breast-cancer`", con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader reader;

                OpenConnection();

                List<DataModel> list = new List<DataModel>();

                try
                {
                    reader = cmd.ExecuteReader();  

                    DataModel model = new DataModel();

                    while (reader.Read())
                    {
                        model.Id = reader.GetInt32("Id");
                        model.Age = reader.GetInt32("Age");
                        model.Menopause = reader.GetInt32("Menopause");

                        list.Add(model);
                    }

                    return list;
                }
                catch(Exception e)
                {
                    return null;
                }

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
