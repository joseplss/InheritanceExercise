using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        public bool HaveTail { get; set; }
        public bool ScalySkin { get; set; } = true;
        public int HowManyEggs { get; set; }
        public bool Crawl { get; set; } = true;
    }
}
