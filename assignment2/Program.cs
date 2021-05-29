using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program atmProgram = new Program();
            atmProgram.Start();
        }

        void Start()
        {
            ATMMachine machine = new ATMMachine(2000);
            bool exit = false;


            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter a command: ");

                Console.ForegroundColor = ConsoleColor.Green;
                string userInput = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Gray;
                userInput = userInput?.ToLower(); // Check if null before ToLower

                switch (userInput)
                {
                    case "stop":
                        exit = true;
                        break;
                    case "insert card":
                        machine.InsertCard();
                        break;
                    case "reject card":
                        machine.RejectCard();
                        break;
                    case "enter pincode":
                        machine.EnterPincode();
                        break;
                    case "withdraw cash":
                        machine.WithDrawCash();
                        break;
                    default:
                        Console.WriteLine("entered unknown command");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}