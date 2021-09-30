using System;
using class_work.dice;

namespace class_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice6 d6=new Dice6();
            Dice9 d9=new Dice9();
            Console.WriteLine($"{d6.play()}");
            Console.WriteLine($"{d9.play()}");  
        }
    }
}
