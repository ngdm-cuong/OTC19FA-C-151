using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Serialization
{

    /// <summary>
    /// static methods to connect to, disconnect from, store data to and retrieve data from database Person table
    /// </summary>
    static class DataAdapter
    {
        static SqlConnection oConn = new SqlConnection("Data Source=stusql-cis151-101-fa19.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
                                                        "Initial Catalog=nguyencu; User Id=nguyencu; Password=897437");

        public static void Connect()
        {
            try
            {
                oConn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO Person1(Data) VALUES(@data)";

            try
            {
                Connect();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@data", data);

                cmdIns.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void Get()
        {
            string sql = "SELECT * FROM Person1";

            SqlCommand cmd = new SqlCommand(sql, oConn);

            try
            {
                Connect();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    //while we are getting records from the DB
                    //we need to be deserializing them and
                    //creating objects
                    Serializer.DeSerializeNow(reader["Data"].ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }

        }
    }
}
