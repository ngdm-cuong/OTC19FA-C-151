using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Final
{
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
            catch (Exception ex)
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
        /// <summary>
        /// Author: Cuong Nguyen
        /// Purpose: Get data and push them to the Data Column in the Jeopardy table, ID is auto created
        /// </summary>
        /// <param name="aPackage"></param>
        /// <param name="data"></param>
        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO Jeopardy(Data) VALUES(@data)";
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

        //public static ArrayList Get()
        //{
        //    string sql = "SELECT * FROM Jeopardy ";
        //    SqlCommand cmd = new SqlCommand(sql, oConn);
        //    string returnData = "";

        //    try
        //    {

        //        Connect();

        //        SqlDataReader reader = cmd.ExecuteReader();


        //            while (reader.Read())
        //            {
        //                for (int i = 0; i < reader.FieldCount; i++)
        //                {
        //                      returnData += reader.GetValue(i).ToString();
        //                }
        //            }
        //          Console.WriteLine(returnData);


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Disconnect();
        //    }
        //    return returnData;
        //}
    }
}
