namespace assignment2
{
    public interface IATMState
    {
        void InsertCard();
        void RejectCard();
        void EnterPincode();
        void WithdrawCash();
    }
}