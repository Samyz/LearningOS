using System;

namespace OS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Experiment number => ");
            string input = Console.ReadLine();
            if (input.Length == 1){
                if (input[0] == '1')
                    ex1.execute();
                else if (input[0] == '2')
                    ex2.execute();
                else if (input[0] == '3')
                    ex3.execute(0);
                else if (input[0] == '4')
                    ex4.execute();
                else if (input[0] == '5')
                    ex5.execute();
                else if (input[0] == '6')
                    ex6.execute();
                else
                    Console.WriteLine("No Experiment found");
            }
            else {
                if (input == "3.1")
                    ex3.execute(1);
                else
                    Console.WriteLine("No Experiment found");
            }
        }
    }
}
