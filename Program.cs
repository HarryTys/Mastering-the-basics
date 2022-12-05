using System;
using System.Text;

namespace C_Sharp_Controlled_Iteration
{
    class C_Sharp_Controlled_Iteration
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What year were your born in?");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi " + name + "," + "\nI think you are " + (2022 - birthYear) + ",");
            if (2022 - birthYear < 18 && 2022 - birthYear > 12) { Console.WriteLine("That means your are a teenager."); }
            else if (2022 - birthYear < 12) { Console.WriteLine("That means you are a child."); }
            else if (2022 - birthYear >= 18) { Console.WriteLine("That means you are an adult."); }
            Console.ReadLine();
        }
    }
}
