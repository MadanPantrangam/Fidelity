using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Day01.Day18
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
            string data=($"{CustomerName} of Id is {CustomerID} his Visit Date {Visit} his contact no {Contact} And His City is {City}");
            return data;
        }

    }
    class DatabaseApp
    {
        static string ConnectionString = @"Data Source=.\SQLEXPRESSNEW;Initial Catalog=TrainningDB;Integrated Security=True";

        static string strSelect = "SELECT CustomerName,ContactNo from Customer";
        static void ConnectToDB()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                Console.WriteLine("Connection is Succesfully!!");
                con.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message); 
            }
            finally
            {
                con.Dispose();
            }
        }

        static void readNamesOfCustomers()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(strSelect, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("Customer Name : "+reader["CustomerName"]+" , Contact No : "+reader["ContactNo"]);
                }
                con.Close();    
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            finally
            {
                con.Dispose();
                cmd.Dispose();
            }
        }

        static void displayAllDetails()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from customer", con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"Details Of {reader[1]}");
                    Console.WriteLine($"Id {reader[0]}");
                    DateTime dt = Convert.ToDateTime(reader[2]);
                    Console.WriteLine($"Visit Date : {dt.ToShortDateString()}");
                    Console.WriteLine($"Phone No :  {reader[3]}");
                    Console.WriteLine($"City :  {reader[4]}");
                    Console.WriteLine("---------------------------------");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        static List<Customer> getAllCustomers()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from customer", con);
            List<Customer> _customers = new List<Customer>();
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var cst = new Customer();
                    cst.CustomerID = Convert.ToInt32(reader[0]);
                    cst.CustomerName = reader[1].ToString();
                    cst.Visit = Convert.ToDateTime(reader[2]);
                    cst.Contact = (int)Convert.ToInt64(reader[3]);
                    cst.City = reader[4].ToString();
                    _customers.Add(cst);
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
            return _customers;
        }

        static Customer findCustomer(int id)
        {
            var obj = new Customer();
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand($"Select * from customer where CustomerID = {id}", con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj.CustomerID= Convert.ToInt32(reader[0]);
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

        static void deleteCustomer(int id)
        {
            var query= $"delete from customer where CustomerID = @id";
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
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

        static void updateCustomer(int id, string name, string city, long phone)
        {
            var query = "update customer set CustomerName=@name,VisitTime=@visit,ContactNo=@Phone,City=@city where CustomerId=@id";
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@visit", DateTime.Now);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@city", city);
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
            }
        }
        static void addCustomer(int id,string name,string city,long phone)
        {
            //InsertData(id, name, city, phone);

            var query = "insert into customer values(@id,@name,@visit,@phone,@city)";
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@visit", DateTime.Now);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@city", city);
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
            }
        }

        private static void InsertData(int id, string name, string city, long phone)
        {
            var insertStatement = $"insert into customer values ({id},'{name}','{DateTime.Now.ToShortDateString()}','{phone}','{city}')";
            using (var con = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(insertStatement, con);
                try
                {
                    con.Open();
                    var rowsafected = cmd.ExecuteNonQuery();
                    if (rowsafected == 1)
                    {
                        Console.WriteLine("Added");
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            // ConnectToDB();
            // readNamesOfCustomers();
            // displayAllDetails();

            //var list = getAllCustomers();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Enter the Customer Id for delete");
            //var id = int.Parse(Console.ReadLine());
            // deleteCustomer(id);
            // Console.WriteLine(data);
            updateCustomer(1001, "Rakesh Kumar", "Bangalore", 987654321);
            Console.ReadLine();
        }
    }
}
