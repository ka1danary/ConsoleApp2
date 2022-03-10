using System;
using ConsoleApp2;
using ConsoleApp2.Strategy;



//есть пруд с утками разных типов, одни умеют летать и квакать, другие не умеют это делать, потому что это, к примеру, абстрактные резиновые утки, они могут только пищать и плавать)


namespace ConsoleApp2
{

    class Program
    {
        internal static void Do(Duck newDuck)
        {
            newDuck.quack();
            newDuck.swim();
        }

        static void Main(string[] args)
        {
            Duck normalDuck = new Duck(new NormalSwim(), new NormalQuack());
            Duck abnormalDuck = new Duck(new AbnormalSwim(), new AbnormalQuack());

            Program.Do(abnormalDuck);
            Program.Do(abnormalDuck);

        }
    }
}
