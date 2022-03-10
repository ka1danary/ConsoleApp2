using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Strategy
{
    internal class NormalQuack : CanQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can real Quack");
        }
    }
}
