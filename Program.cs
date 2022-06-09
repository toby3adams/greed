using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using greed.Game;
using greed.Game.Objects;
using greed.Game.Services;

namespace greed{
    class Program {
        
        static void Main(string[] args)
        { 
            Director director = new Director();
            director.StartGame();
        }
    }
}
