using System;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        private ATMMachine _machine;

        public NoCardState(ATMMachine machine)
        {
            _machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            _machine.SetMachineState(_machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("No card has been inserted");
        }

        public void EnterPincode()
        {
            Console.WriteLine("No card has been inserted");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("No card has been inserted");
        }
    }
}