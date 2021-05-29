using System;

namespace assignment2
{
    public class ATMMachine
    {
        private double _amountInMachine;
        private IATMState _cardPresent;
        private IATMState _correctPinCode;
        private IATMState _noCard;
        private IATMState _noCash;
        private IATMState _machineState;

        public double AmountInMachine
        {
            get => _amountInMachine;
            private set => _amountInMachine = value;
        }

        public ATMMachine(int amount)
        {
            _amountInMachine = amount;
            _correctPinCode = new CorrectPinState(this);
            _cardPresent = new CardPresentState(this);
            _noCard = new NoCardState(this);
            _noCash = new NoCashState(this);

            _machineState = _noCard;
        }

        public void EnterPincode()
        {
            _machineState.EnterPincode();
        }

        public void InsertCard()
        {
            _machineState.InsertCard();
        }

        public void RejectCard()
        {
            _machineState.RejectCard();
        }

        public void WithDrawCash()
        {
            _machineState.WithdrawCash();
        }

        public void SetAmountInMachine(double amount)
        {
            AmountInMachine = amount >= 0 ? amount : throw new ArgumentException("Cannot have negative amount in ATM");
        }

        public void SetMachineState(IATMState state)
        {
            _machineState = state;
        }

        public IATMState GetCardPresentState()
        {
            return _cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return _correctPinCode;
        }

        public IATMState GetNoCardState()
        {
            return _noCard;
        }

        public IATMState GetNoCashState()
        {
            return _noCash;
        }
    }
}