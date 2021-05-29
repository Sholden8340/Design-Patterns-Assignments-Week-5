using System;

namespace assignment2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine _machine;

        public CorrectPinState(ATMMachine machine)
        {
            _machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            _machine.SetMachineState(_machine.GetNoCardState());
        }


        public void EnterPincode()
        {
            Console.WriteLine("Pincode already accepted");
        }

        public void WithdrawCash()
        {
            Console.Write("Please enter amount of cash: ");
            int amount = Int32.Parse(Console.ReadLine() ?? "0");

            if ((_machine.AmountInMachine - amount) >= 0)
            {
                _machine.SetAmountInMachine(_machine.AmountInMachine - amount);
                Console.WriteLine($"{amount} withdrawn from machine");
            }
            else
            {
                Console.WriteLine("Not enough cash available in machine");
                _machine.SetMachineState(_machine.GetNoCashState());
            }

            Console.WriteLine("Your card has been rejected");
            _machine.SetMachineState(_machine.GetNoCardState());
        }
    }
}