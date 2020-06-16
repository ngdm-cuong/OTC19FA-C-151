using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
/// <summary>
/// Author: Cuong Nguyen
/// </summary>
namespace ShippingG5c
{

    static class DataAdapter
    {
        public static ArrayList Invoices = new ArrayList(); // Contain all the invoice 
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
        /// Purpose: Insert aPackage.ID to the ID column, and the serialized data (the Package.Tostring) to the InvoiceData Column
        /// </summary>
        /// <param name="aPackage"></param>
        /// <param name="data"></param>
        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO InvoiceG5(InvoiceData) VALUES(@data)";
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
        /// <summary>
        /// Author: Cuong Nguyen
        /// Trying to add the object to the local C# array, and return the whole array
        /// </summary>
        //public static ArrayList Get()
        //{
        //    string sql = "SELECT * FROM InvoiceG5 ";
        //    string[,] PackagesStrArray = new string[99, 2];
        //    SqlCommand cmd = new SqlCommand(sql, oConn);

        //    try
        //    {

        //        Connect();

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        Console.WriteLine("asdasdsad");

               
        //        {
        //            int j = 0;
        //            while (reader.Read())
        //            {
        //                //FullTime item = new FullTime(reader);

        //                for (int i = 0; i < reader.FieldCount; i++)
        //                {
        //                    PackagesStrArray[j, i] = reader.GetValue(i).ToString();
        //                }
        //                Package aPackage = new Package();


        //                Invoices.Packages.Add(aPackage);
        //                j++;
        //                Console.WriteLine(Invoices.Packages.Count);
        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Disconnect();
        //    }
        //    return Invoices.Packages;
        //}
    }
}

