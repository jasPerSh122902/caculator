using System;
using System.Collections.Generic;
using System.Text;
namespace caculator
{

    class Game
    {
        public int number1 = 0;
        public int number2 = 0;
        public int result = 0;
        string input = "";
       public float inputvalue = 0;
        public string inputRecieved = Console.ReadLine();
        public int Add(int number1, int number2)
        {

            //the adding process
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
            return result = number1 %= number2;
        }

        public int subtract(int number1, int number2)
        {
            Console.ReadLine();
            return result = number1 -= number2;
        }
        public void Run()
        {
            Console.WriteLine("caculations");
            Console.WriteLine("write +, -, *, %_Write the word");
            Console.ReadLine();
            if(!float.TryParse(input, out inputvalue))
            {
                if (inputRecieved == "plus" || inputRecieved == "subtract" || inputRecieved == "multipy" || inputRecieved == "divide")
                {
                    if (inputRecieved == "plus" || inputRecieved == "+")
                    {

                        Add(0, 0);
                        Console.ReadLine();
                        Console.WriteLine("product = ", result);
                        Run();
                    }

                    else if (inputRecieved == "subtract" || inputRecieved == "-")
                    {

                        subtract(0, 0);
                        Console.ReadLine();
                        Console.WriteLine();
                        Run();
                    }

                    else if (inputRecieved == "multiply" || inputRecieved == "*")
                    {

                        multiply(0, 0);
                        Console.ReadLine();
                        Console.WriteLine();
                        Run();
                    }

                    else if (inputRecieved == "divide" || inputRecieved == "%")
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
}



