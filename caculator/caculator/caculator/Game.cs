using System;
using System.Collections.Generic;
using System.Text;
namespace caculator
{

    class Game
    {
        //the numbers that are needed
        public int number1 = 0;
        public int number2 = 0;
        //the result value
        public int result = 0;

        //the input 
        string input = "";
        public float inputvalue = 0;
        public string inputRecieved = Console.ReadLine();

        //the functions
        public int Add(int number1, int number2)
        {

            //the adding process

            Console.ReadLine();
            return result = number1 += number2;

        }

        public float multiply(int number1, int number2)
        {

            //multiply
            Console.ReadLine();
            return result = number1 *= number2;
        }

        public float divide(int number1, int number2)
        {

            //dividing process 
            Console.ReadLine();
            return result = number1 %= number2;
        }

        public int subtract(int number1, int number2)
        {
            //subtraction 
            Console.ReadLine();
            return result = number1 -= number2;
        }
        public void Run()
        {
            //the beging lines that come in 
            Console.WriteLine("caculations");
            Console.WriteLine("write +, -, *, %_Write the word");

            //if the input is some word then that word is going to spit out a number from the if statment

                Console.ReadLine();
                if (inputRecieved == "plus" || inputRecieved == "+")
                {

                    Add(number1, number2);
                    Console.ReadLine();
                    Console.WriteLine("product = ", number1);
                    Console.Clear();
                    Run();
                }

                else if (inputRecieved == "subtract" || inputRecieved == "-")
                {

                    subtract(number1, number2);
                    Console.ReadLine();
                    Console.WriteLine("product = ", result);
                    Console.Clear();
                    Run();
                }

                else if (inputRecieved == "multiply" || inputRecieved == "*")
                {

                    multiply(number1, number2);
                    Console.ReadLine();
                    Console.WriteLine("product = ", result);
                    Console.Clear();
                    Run();
                }

                else if (inputRecieved == "divide" || inputRecieved == "%")
                {

                    divide(number1, number2);
                    Console.ReadLine();
                    Console.WriteLine("product = ", result);
                    Console.Clear();
                    Run();
                }

                //error statment
                else
                {
                    Console.WriteLine("error");
                    Console.Clear();
                    Run();
                }
            }

    }
}
