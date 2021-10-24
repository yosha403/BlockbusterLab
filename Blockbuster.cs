using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class Blockbuster
    {
        public List<Movie> movieList = new List<Movie>();
        public List<string> Genre = new List<string>() { "Drama", "Comedy", "Horror", "Romance", "Action" };

        //Initialized a list of 6 movies, in which 3 are DVDs and 3 are VHS.
        public Blockbuster()
        {
            List<string> scenes1 = new List<string>() { "scene0", "scene1", "scene2", "scene3", "scene4", "scene5" };
            movieList.Add(new DVD("Mission Impossible", "Action", 120, scenes1));

            List<string> scenes2 = new List<string>() { "scene0", "scene1", "scene2", "scene3", "scene4", "scene5" };
            movieList.Add(new DVD("Bad Boys", "Comedy", 135, scenes2));

            List<string> scenes3 = new List<string>() { "scene0", "scene1", "scene2", "scene3", "scene4", "scene5" };
            movieList.Add(new DVD("Annabelle", "Horror", 140, scenes3));

            List<string> scenes4 = new List<string>() { "scene0", "scene1", "scene2", "scene3", "scene4", "scene5" };
            movieList.Add(new VHS("The bridges of Madison county", "Drama", 150, scenes4));

            List<string> scenes5 = new List<string>() { "scene0", "scene1", "scene2", "scene3", "scene4", "scene5" };
            movieList.Add(new VHS("Sleepless in Seatle", "Romance", 115, scenes5));

            List<string> scenes6 = new List<string>() { "scene0", "scene1", "scene2", "scene3", "scene4", "scene5" };
            movieList.Add(new VHS("SkyFall", "Action", 105, scenes6));
        }

        //A method to print all the movies
        public void PrintMovies()
        {          
            for(int i=0;i<movieList.Count;i++)
            {
                Console.WriteLine($"{i}) {movieList[i].Title}");
            }
            Console.WriteLine();
        }

        //A method to checkout a movie
        public void Checkout()
        {
            bool movieFound = false;
            PrintMovies();
            Console.Write("Please select a movie you want to watch(Select number 0-5): ");
            try
            {


                int index = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i < movieList.Count; i++)
                {
                    if (i == index)
                    {
                        Console.WriteLine(movieList[i]);
                        movieFound = true;
                        Console.Write("\nDo you want to watch the movie? Y/N: ");
                        if (Console.ReadLine().ToString() == "y")
                        {                           
                            Console.WriteLine($"\nWhich Scene of {movieList[i].Title} would you like to watch ? Select 0 to 5: ");
                            int scene = int.Parse(Console.ReadLine());
                            for(int j=0;j<movieList[i].Scenes.Count;j++)
                            {
                                Console.WriteLine($"Scene playing: {movieList[i].Scenes[scene]}");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Thank you!");
                        }                       
                    }
                }
                if (movieFound == false)
                {
                    Console.WriteLine("\nPlease select a movie from the list.");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }     
    }
}
