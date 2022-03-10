using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Strategy
{
    internal class NormalSwim : CanSwim
    {
        public void Swim()
        {
            Console.WriteLine("I can real swim");
        }
    }
}
