using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2;
using ConsoleApp2.Strategy;

namespace ConsoleApp2
{
    internal class Duck
    {
            private CanSwim Swiming;
            private CanQuack Quacking;
            

        public Duck(CanSwim Swiming, CanQuack Quaking)
        {
            this.Swiming = Swiming;
            this.Quacking = Quaking;

        }

        internal void swim()
        {
            Swiming.Swim();

        }

        internal void quack()
        {
            Quacking.Quack();
        }

    }
}
