using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;            
        }
        //Override play method
        public override void Play()
        {
            Console.WriteLine("Please select a scene: ");
            int scene = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scene playing: {Scenes[scene]}");
        }
    }
}
