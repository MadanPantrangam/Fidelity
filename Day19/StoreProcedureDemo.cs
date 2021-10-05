using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace Day01.Day19
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Visit { get; set; }
        public int Contact { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            string data = ($"{CustomerName} of Id is {CustomerID} his Visit Date {Visit} his contact no {Contact} And His City is {City}");
            return data;
        }

    }
    class StoreProcedureDemo
    {
        public static string strCon = ConfigurationManager.ConnectionStrings["localCon"].ConnectionString;
        static void InsertProcedure()
        {
            string query = "InsertCustomer";
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", 2000);
            cmd.Parameters.AddWithValue("@name", "Chai");
            cmd.Parameters.AddWithValue("@contact", 7093599231);
            cmd.Parameters.AddWithValue("@city", "Bangalore");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
                cmd.Dispose();
            }
        }

        static Customer FindCustomerById(int id)
        {
            var obj = new Customer();
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand($"FindCustomerById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj.CustomerID = Convert.ToInt32(reader[0]);
                    obj.CustomerName = reader[1].ToString();
                    obj.Visit = Convert.ToDateTime(reader[2]);
                    obj.Contact = (int)Convert.ToInt64(reader[3]);
                    obj.City = reader[4].ToString();
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
                cmd.Dispose();
            }

            return obj;
        }

        static void InsertStudent()
        {
            string query = "InsertStudent";
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int studenntId = 0;
            cmd.Parameters.AddWithValue("@name", "Somesh");
            cmd.Parameters.AddWithValue("@marks", 98);
            cmd.Parameters.AddWithValue("@age", 22);
            cmd.Parameters.AddWithValue("@id", studenntId);
            cmd.Parameters[3].Direction = System.Data.ParameterDirection.Output;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                studenntId = Convert.ToInt32(cmd.Parameters[3].Value);
                Console.WriteLine("The Id of New Student is "+studenntId);
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
                cmd.Dispose();
            }
        }

        static void Main(string[] args)
        {
            // InsertProcedure();
            //var data=FindCustomerById(8);
            //Console.WriteLine(data);
            //Console.WriteLine("Succesfully Added!!");
            InsertStudent();
            Console.ReadLine();
        }
    }
}
