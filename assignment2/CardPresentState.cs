using System;

namespace assignment2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine _machine;

        public CardPresentState(ATMMachine machine)
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
            Console.Write("Please enter your pincode: ");
            Console.ReadLine();
            Console.WriteLine("You have entered the correct pincode");
            _machine.SetMachineState(_machine.GetCorrectPinState());
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Please enter your pincode");
        }
    }
}