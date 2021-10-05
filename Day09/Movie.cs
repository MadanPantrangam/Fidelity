using Day01.Day03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day09
{
    class Movie
    {
        public Movie()
        {
            Id = MovieCount++;
        }
        private static int MovieCount = 0;
        public int Id { get; set; } 
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }
    }

    interface IMovieDataBase
    {
       void AddNewMovieToDatabase(Movie movie);
        void GetAMovie(int id);
        List<Movie> FindMoviesByDirector(string director);
        List<Movie> FindMovieByName(string movieName);
        List<Movie> GetTopRatedMovies(int rating);
    }

    class MovieDB : IMovieDataBase
    {
        Movie movie = new Movie();
        List<Movie> movieList = new List<Movie>();
        Movie[] arrayMovie = new Movie[10];
        public void AddNewMovieToDatabase(Movie movie)
        {
            for (int i = 0; i < arrayMovie.Length; i++)
            {
                if (arrayMovie[i] == null)
                {
                    arrayMovie[i] = movie;
                    return;
                }
                else continue;
            }
        }

        public List<Movie> FindMovieByName(string movieName)
        {
            var temp = new List<Movie>();
            for (int i = 0; i < arrayMovie.Length; i++)
            {
                if(arrayMovie[i].MovieName==movieName)
                {
                    temp.Add(arrayMovie[i]);
                }
            }
            return temp;
        }

        public List<Movie> FindMoviesByDirector(string director)
        {
            var temp = new List<Movie>();
            for (int i = 0; i < arrayMovie.Length; i++)
            {
                if (arrayMovie[i].Director == director)
                {
                    temp.Add(arrayMovie[i]);
                }
            }
            return temp;
        }
        //var records = _employee.Find((e) => e.EmpId == id);
        //    if (records == null) Console.WriteLine($"Employee {id} is Not Found");
        //    return records;
        public void GetAMovie(int id)
        {
            var temp = new List<Movie>();
            for (int i = 0; i < arrayMovie.Length; i++)
            {
                if (arrayMovie[i].Id == id)
                {
                    temp.Add(arrayMovie[i]);
                }
            }
        }

        public List<Movie> GetTopRatedMovies(int rating)
        {
            throw new NotImplementedException();
        }
    }
    class MovieDataBase 
    {
        static MovieDB app = new MovieDB();
       static Movie obj = new Movie();

        const string Menu = "-------------------------Movie DataBase--------------------- \n Add New Movie -------------Press 1\n Get A Movie   -------------Press 2\nFind Movies By Director ---Press 3\n Find Movie By Name --------Press 4 \n Get Top Rated Movies-------Press 5";


        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                var choice = HelperClass.GetNumber(Menu);
                processing = ProcessMenu(choice);
            } while (processing);
           
        }

        private static bool ProcessMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addMovieDetails();
                    return true;
                case 2:
                    getMovieById();
                    return true;
                case 3:
                    findDirectorByName();
                    return true;
                case 4:
                    findMovieByName();
                    return true;
                case 5:
                    getTopRatedMovies();
                    return true;

            }
            return false;
        }

        private static void getTopRatedMovies()
        {
            throw new NotImplementedException();
        }

        private static void getMovieById()
        {
            int id = HelperClass.GetNumber("Enter Movie Id for Finding The Movie");
            app.GetAMovie(id);
        }

        static void findDirectorByName()
        {
            string directName = HelperClass.GetString("Enter Director Name For Searching");
            var data = app.FindMoviesByDirector(directName);
            foreach (var item in data)
            {
                Console.WriteLine($"Id : {item.Id} MovieName : {item.MovieName} Release Date : {item.ReleaseDate} Duration : {item.Duration} Director : {item.Director} Rating : {item.Rating}");
            }
        }

        static void findMovieByName()
        {
            string movieName = HelperClass.GetString("Enter Movie Name For Seacrching");
            var data = app.FindMovieByName(movieName);
            foreach (var item in data)
            {
                Console.WriteLine($"Id : {item.Id} MovieName : {item.MovieName} Release Date : {item.ReleaseDate} Duration : {item.Duration} Director : {item.Director} Rating : {item.Rating}");
            }
        }
        static void addMovieDetails()
        {
            obj.MovieName = HelperClass.GetString("Enter Movie Name");
            obj.ReleaseDate = HelperClass.GetDate("Enter Release Date");
            obj.Duration = HelperClass.GetString("Enter Movie Duration");
            obj.Director = HelperClass.GetString("Enter Movie Director");
            obj.Rating = HelperClass.GetNumber("Enter Movie Rating");
            app.AddNewMovieToDatabase(obj);
        }
    }
}
