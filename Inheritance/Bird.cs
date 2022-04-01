using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Color = "red";
            Size = 32;
            Name = "Mordekaiser";
            HaveLegs = true;
        }
        public bool HaveBeak { get; set; } = true;
        public bool HaveWings { get; set; }
        public int FeatherCount { get; set; }
        public bool LayEggs { get; set; } = true;
    }
}
