using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Min_v._2._0
{
    class Test
    {
        private static volatile Test instance;
        private Test() { }
        private string str = @"Data Source=DESKTOP-NBO6IVB;Initial Catalog=ScoreData;Integrated Security=True";
        static object key = new object();
        public static Test Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new Test();
                    }
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable("data");
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }

                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }

                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }

                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
