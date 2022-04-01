using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
            Color = "green";
            Size = 1;
            Name = "Lizardy";
            HaveLegs = true;
        }
        public string Color { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public bool HaveLegs { get; set; }
    }
}
