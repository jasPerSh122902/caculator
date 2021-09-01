using System;
using System.Collections.Generic;
using System.Text;
namespace caculator
{

    class Game
    {
        public int number1 = 0;
        public int number2 = 0;
        public string input = Console.ReadLine();
        public int Add(int number1, int number2)
        {
            Console.ReadLine();
            return number1 += number2;

        }

        public float multiply(int number1, int number2)
        {
            Console.ReadLine();
            return number1 *= number2;
        }

        public float divide(int number1, int number2)
        {
            Console.ReadLine();
            return number1 %= number2;
        }

        public int subtract(int number1, int number2)
        {
            Console.ReadLine();
            return number1 -= number2;
        }
        public void Run()
        {
            Console.WriteLine("caculations");
            Console.WriteLine("write +, -, *, %_Write the word");
            Console.ReadLine();
            if (input == "plus" || input == "subtract" || input == "multipy" || input == "divide")
            {
                if(input == "plus")
                {
                    
                    Add(0, 0);
                    Console.ReadLine();
                    Console.WriteLine();
                    Run();
                }

                if(input == "subtract")
                {
                    
                    subtract(0, 0);
                    Console.ReadLine();
                    Console.WriteLine();
                    Run();
                }

                if(input == "multiply")
                {
                    
                    multiply(0, 0);
                    Console.ReadLine();
                    Console.WriteLine();
                    Run();
                }

                if(input == "divide")
                {
                    
                    divide(0, 0);
                    Console.ReadLine();
                    Console.WriteLine();
                    Run();
                }

                else
                {
                    Console.ReadLine();
                    Console.ReadKey();
                    Console.WriteLine("error");
                    Run();
                }
            }
        }
    }
}




