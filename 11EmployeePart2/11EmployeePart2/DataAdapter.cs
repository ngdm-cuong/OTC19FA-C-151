using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;


namespace _11EmployeePart2
{

    static class DataAdapter
    {
        public static ArrayList FullTimeEmployees = new ArrayList();

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

        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO Person(Data) VALUES(@data)";

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
        /// Purpose: Connect to database and add objects of data
        /// </summary>
        /// <returns></returns>
        public static ArrayList Get()
        {
            
            string sql = "SELECT * FROM Employee LEFT JOIN FullTime ON Employee.ID = FullTime.ID; ";
            string [,] FulltimeStrArray = new string [3,14];

            


            SqlCommand cmd = new SqlCommand(sql, oConn);

            try
            {
              //  Form1 frm1 = new Form1();
                Connect();

                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("asdasdsad");

                //while (reader.Read())
                //{
                //    //while we are getting records from the DB
                //    Serializer.DeSerializeNow(reader["Data"].ToString());
                //}
               // for (int j = 0; j <= FulltimeStrArray.Length; j++)
                {
                    int j = 0;
                    while (reader.Read())
                    {
                    //FullTime item = new FullTime(reader);
                        
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            FulltimeStrArray[j, i] = reader.GetValue(i).ToString();
                        }
                        FullTime aFulltime = new FullTime();
                        aFulltime.ID = Convert.ToInt32(FulltimeStrArray[j, 0]);
                        aFulltime.FirstNanme = FulltimeStrArray[j, 1];
                        aFulltime.LastName = FulltimeStrArray[j, 2];
                        aFulltime.DateHired = Convert.ToDateTime(FulltimeStrArray[j, 3]);
                        aFulltime.SSN = FulltimeStrArray[j, 4];
                        aFulltime.Email = FulltimeStrArray[j, 5];
                        aFulltime.Phone = FulltimeStrArray[j, 6];
                        aFulltime.TaxRate = Convert.ToDecimal(FulltimeStrArray[j, 7]);
                        aFulltime.ID = Convert.ToInt32(FulltimeStrArray[j, 8]);
                        aFulltime.Salary = Convert.ToDecimal(FulltimeStrArray[j, 9]);
                        aFulltime.NumOfVacationDays = Convert.ToInt32(FulltimeStrArray[j, 10]);
                        aFulltime.HasInsurance = FulltimeStrArray[j, 11];
                        aFulltime.TaxExempt = FulltimeStrArray[j, 12];
                        aFulltime.NumOfSickDays = Convert.ToInt32(FulltimeStrArray[j, 13]);

                        FullTimeEmployees.Add(aFulltime);
                        j++;



                        //frm1.listBox1.Items.Add(aFulltime);

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return FullTimeEmployees;
        }// End of get
    }
}

