using System;

namespace assignment1
{
    public class SubSystem
    {
        private Logger _logger = Logger.GetInstance();

        public void DoSomeWork()
        {
            _logger.Log("SubSystem", "doing some work");
            DoSomeMoreWork();
        }

        public void DoSomeMoreWork()
        {
         _logger.Log("SubSystem", "doing some more work");   
        }
    }
}