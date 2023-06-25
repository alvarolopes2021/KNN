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

                    while (reader.Read())
                    {
                        DataModel model = new DataModel();

                        model.Id = reader.GetInt32("id");
                        model.Age = reader.GetInt32("age");
                        model.Menopause = reader.GetInt32("menopause");
                        model.TumorSize = reader.GetInt32("tumor-size");
                        model.InvNodes = reader.GetInt32("inv-nodes");
                        model.NodeCaps = reader.GetInt32("node-caps");
                        model.DegMalig = reader.GetInt32("deg-malig");
                        model.Breast = reader.GetInt32("breast");
                        model.BreastQuad = reader.GetInt32("breast-quad");
                        model.Irradiat = reader.GetInt32("irradiat");
                        model.Class = reader.GetInt32("class");

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
