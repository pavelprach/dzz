using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Box
    {
        public int volume { set; get; }
        public int weight_box { set; get; }
        public Box() { }
        public Box(int volume,int weight_box)
        {
            this.volume = volume;
            this.weight_box = weight_box;
        }
    }
}
