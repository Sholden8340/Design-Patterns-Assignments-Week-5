namespace assignment1
{
    public class MainSystem
    {
        private SubSystem _subSystem;
        public MainSystem()
        {
            _subSystem = new SubSystem();
        }

        public void DoSomeWork()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("MainSystem", "doing some main work");
            _subSystem.DoSomeWork();
        }
    }
}