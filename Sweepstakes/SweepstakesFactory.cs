using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactory
    {
        public static ISweepstakesManager CreateSweepstakes()
        {
            
            switch (UserInterface.GetUserInputFor("Choose sweepstakes management style for this sweepstakes?\n Press 1 for stack, Press 2 for queue"))
            {
                case "1":
                    return new SweepstakesStackManager();
                case "2":
                    return new SweepstakesQueueManager();
                default:
                    return CreateSweepstakes();
            }
            
        }
    }
}
