using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApplication
{
    class Player
    {
        public Player(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        
        public void Play()
        {
            Console.WriteLine($"Player {Name} is playing");
        }
    }
}
