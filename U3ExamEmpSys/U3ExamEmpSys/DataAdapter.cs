using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace U3ExamEmpSys
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

        public static void Insert(FullTime data)
        {
            string sqlIns = $"INSERT INTO Employee(ID, FirstName, LastName, DateHired, SSN, Email, Phone,TaxRate) VALUES(@ID, @FirstName, @LastName, @DateHired, @SSN, @Email, @Phone,@TaxRate);";
            string sqlIns_1= $"INSERT INTO FullTime(ID, Salary, NumOfVacationDays, HasUInsurance, TaxExempt, NumOfSickDays) VALUES(@ID, @Salary, @NumOfVacationDays, @HasUInsurance, @TaxExempt, @NumOfSickDays);";

            try
            {
                Connect();
                
                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@ID", data.ID);
                cmdIns.Parameters.AddWithValue("@FirstName", data.FirstNanme);
                cmdIns.Parameters.AddWithValue("@LastName", data.LastName);
                cmdIns.Parameters.AddWithValue("@DateHired", data.DateHired);
                cmdIns.Parameters.AddWithValue("@SSN", data.SSN);
                cmdIns.Parameters.AddWithValue("@Email", data.Email);
                cmdIns.Parameters.AddWithValue("@Phone", data.Phone);
                cmdIns.Parameters.AddWithValue("@TaxRate", data.TaxRate);
                cmdIns.ExecuteNonQuery();

                SqlCommand cmdIns_1= new SqlCommand(sqlIns_1, oConn);
                cmdIns_1.Parameters.AddWithValue("@ID", data.ID);
                cmdIns_1.Parameters.AddWithValue("@Salary", data.Salary);
                cmdIns_1.Parameters.AddWithValue("@NumOfVacationDays", data.NumOfVacationDays);
                cmdIns_1.Parameters.AddWithValue("@HasUInsurance", data.HasInsurance);
                cmdIns_1.Parameters.AddWithValue("@TaxExempt", data.TaxExempt);
                cmdIns_1.Parameters.AddWithValue("@NumOfSickDays", data.NumOfSickDays);
                cmdIns_1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }// Emd pf Insert
        public static void Update(FullTime data)
        {
            string sqlIns = $"UPDATE Employee SET FirstName = @FirstName , DateHired = @DateHired, SSN = @SSN, Email = @Email, Phone = @Phone, TaxRate = @TaxRate WHERE ID = @condition; ";
            string sqlIns_1 = $"UPDATE  FullTime SET Salary=@Salary, NumOfVacationDays= @NumOfVacationDays, HasUInsurance= @HasUInsurance,TaxExempt= @TaxExempt,NumOfSickDays= @NumOfSickDays) WHERE ID = @condition; ";

            try
            {
                Connect();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);

                cmdIns.Parameters.AddWithValue("@FirstName", data.FirstNanme);
                cmdIns.Parameters.AddWithValue("@LastName", data.LastName);
                cmdIns.Parameters.AddWithValue("@DateHired", data.DateHired);
                cmdIns.Parameters.AddWithValue("@SSN", data.SSN);
                cmdIns.Parameters.AddWithValue("@Email", data.Email);
                cmdIns.Parameters.AddWithValue("@Phone", data.Phone);
                cmdIns.Parameters.AddWithValue("@TaxRate", data.TaxRate);
                cmdIns.Parameters.AddWithValue("@condition", data.ID);
                cmdIns.ExecuteNonQuery();

                SqlCommand cmdIns_1 = new SqlCommand(sqlIns_1, oConn);

                cmdIns_1.Parameters.AddWithValue("@Salary", data.Salary);
                cmdIns_1.Parameters.AddWithValue("@NumOfVacationDays", data.NumOfVacationDays);
                cmdIns_1.Parameters.AddWithValue("@HasUInsurance", data.HasInsurance);
                cmdIns_1.Parameters.AddWithValue("@TaxExempt", data.TaxExempt);
                cmdIns_1.Parameters.AddWithValue("@NumOfSickDays", data.NumOfSickDays);
                cmdIns.Parameters.AddWithValue("@condition", data.ID);
                cmdIns_1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }// End of Update
        public static void Delete(int data)
        {
            string sqlIns = $"DELETE FROM Employee WHERE ID = @iD; ";
            string sqlIns_1 = $"DELETE FROM FullTime WHERE ID = @iD; ";


            try
            {
                Connect();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@iD", data);
                cmdIns.ExecuteNonQuery();

                SqlCommand cmdIns_1 = new SqlCommand(sqlIns_1, oConn);
                cmdIns_1.Parameters.AddWithValue("@iD", data);
                cmdIns_1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }//End of Delete

        /// <summary>
        /// Purpose: Connect to database and add objects of data
        /// </summary>
        /// <returns></returns>
        public static ArrayList Get()
        {

            string sql = "SELECT * FROM Employee LEFT JOIN FullTime ON Employee.ID = FullTime.ID; ";
            string[,] FulltimeStrArray = new string[99, 14];




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
                        Console.WriteLine(FullTimeEmployees.Count);
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
       

    }// End of main class
}// End of namespace
