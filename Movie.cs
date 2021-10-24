using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        public virtual void Play()
        {
            Console.WriteLine("Play movie");
        }

        //Override ToString method to print the details of a selected movie
        public override string ToString()
        {
            string output = $"{Title}\n";
            output += $"Category : {Category}\n";
            output += $"Run Time: {RunTime} minutes";
            return output;
        }
    }
}
