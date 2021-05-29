using System;

namespace assignment2
{
    public class NoCashState : IATMState
    {
        private ATMMachine _machine;

        public NoCashState(ATMMachine machine)
        {
            _machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Not enough cash available in machine");
        }

        public void RejectCard()
        {
            Console.WriteLine("Not enough cash available in machine");
        }

        public void EnterPincode()
        {
            Console.WriteLine("Not enough cash available in machine");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Not enough cash available in machine");
        }
    }
}