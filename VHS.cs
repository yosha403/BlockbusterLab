using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes):base(Title,Category,RunTime,Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
            this.CurrentTime = 0;
        }
        //Override play method
        public override void Play()
        {
            Console.WriteLine($"Scene Played:\n {Scenes[CurrentTime]}");
            CurrentTime++;
            if(CurrentTime>=Scenes.Count)
            {
                Rewind();
            }
        }
        //Reset curenttime to 0 while rewinding the movie
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
