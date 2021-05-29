using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program assignment1 = new Program();
            assignment1.Start();
        }

        void Start()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("main", "starting");
            MainSystem mainSystem = new MainSystem();
            mainSystem.DoSomeWork();
            logger.Log("main", "finishing");
        }
        
    }
}
