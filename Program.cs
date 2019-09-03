using System;

using designPatterns.strategyMode;
using designPatterns.Observer;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniDuckSimulator miniDuck = new MiniDuckSimulator();
            Console.WriteLine(miniDuck);

            RoleWeapon roleWeapon = new RoleWeapon();
            Console.WriteLine(roleWeapon);

            ObserverPatternDemo observer = new ObserverPatternDemo();
            Console.WriteLine(observer);
        }
    }
}
