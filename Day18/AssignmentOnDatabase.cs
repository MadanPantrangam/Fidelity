using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Day01.Day18
{
    class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public int Rating { get; set; }
        public string Duration { get; set; }
    }

    interface IMovie
    {
        void AddMovie(int id, string MovieName, string Director, int Rating, string Duration);
        void DeleteMovie(int id);
        void UpadateMovie(int id, string MovieName, string Director, int Rating, string Duration);
        Movie FindMovie(int id);

        List<Movie> FindMovieByMovieName(string movieName);

        List<Movie> GetAllMovies();
    }

    class MovieCRUD : IMovie
    {
        static string ConnectionString = @"Data Source=.\SQLEXPRESSNEW;Initial Catalog=TrainningDB;Integrated Security=True";
        public void AddMovie(int id, string MovieName, string Director, int Rating, string Duration)
        {
            var query = "insert into movie values(@id,@MovieName,@Director,@MovieRealeseDate,@Rating,@Duration)";
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@MovieName", MovieName);
            cmd.Parameters.AddWithValue("@Director", Director);
            cmd.Parameters.AddWithValue("@MovieRealeseDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Duration", Duration);
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

        public void DeleteMovie(int id)
        {
            var query = $"delete from movie where MovieId = @id";
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

        public Movie FindMovie(int id)
        {
            var obj = new Movie();
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand($"Select * from movie where MovieId = {id}", con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj.MovieId = Convert.ToInt32(reader[0]);
                    obj.MovieName = reader[1].ToString();
                    obj.Director = reader[2].ToString();
                    obj.MovieReleaseDate = Convert.ToDateTime(reader[3]);
                    obj.Rating = Convert.ToInt32(reader[4]);
                    obj.Duration = reader[5].ToString();
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

        public List<Movie> FindMovieByMovieName(string movieName)
        {
            var _movieList = new List<Movie>();
            var obj = new Movie();
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand($"Select * from movie where MovieName like '%{movieName}%'", con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj.MovieId = Convert.ToInt32(reader[0]);
                    obj.MovieName = reader[1].ToString();
                    obj.Director = reader[2].ToString();
                    obj.MovieReleaseDate = Convert.ToDateTime(reader[3]);
                    obj.Rating = Convert.ToInt32(reader[4]);
                    obj.Duration = reader[5].ToString();
                    _movieList.Add(obj);
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

            return _movieList;
        }

        public List<Movie> GetAllMovies()
        {
            var _movieList = new List<Movie>();
            var obj = new Movie();
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("getAllMovieDetails", con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj.MovieId = Convert.ToInt32(reader[0]);
                    obj.MovieName = reader[1].ToString();
                    obj.Director = reader[2].ToString();
                    obj.MovieReleaseDate = Convert.ToDateTime(reader[3]);
                    obj.Rating = Convert.ToInt32(reader[4]);
                    obj.Duration = reader[5].ToString();
                    _movieList.Add(obj);
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

            return _movieList;
        }

        public void UpadateMovie(int id, string MovieName, string Director, int Rating, string Duration)
        {
            var query = "update movie set MovieName=@MovieName,Director=@Director,MovieReleaseDate=@MovieRealeseDate,Rating=@Rating,Duration=@Duration where MovieId=@id";
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@MovieName", MovieName);
            cmd.Parameters.AddWithValue("@Director", Director);
            cmd.Parameters.AddWithValue("@MovieRealeseDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Rating", Rating);
            cmd.Parameters.AddWithValue("@Duration", Duration);
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
    }
    class AssignmentOnDatabase
    {
        static void Main(string[] args)
        {
            MovieCRUD obj = new MovieCRUD();
            //obj.AddMovie(2, "f2", "Anil Ravipodi", 9, "2hr 20 Minutes");
            //obj.AddMovie(3, "Jalsa", "Trivikram", 10, "2hr 30 Minutes");
            // obj.UpadateMovie(3, "Jalsa", "Trivikram", 10, "2hr 25 Minutes");
            // obj.DeleteMovie(3);
            // Console.WriteLine("Updated Successfully!!");
            // var data = obj.FindMovieByMovieName("a");
            var data = obj.GetAllMovies();
            foreach (var item in data)
            {
                Console.WriteLine($"Movie Name : {item.MovieName} by Id {item.MovieId} Of The Director Name {item.Director} Movie Release Date {item.MovieReleaseDate} The Rating {item.Rating} of the movie Duration {item.Duration}");
                Console.WriteLine("-----------------------");
            }
           
            Console.ReadLine();
        }
    }
}
