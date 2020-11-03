using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class Simulation
    {
        public static void CreateMarketingFirmWithManager()
        {
            //switch case - factory design pattern ===> pump em out, broh
            SweepstakesFactory sweepstakesFactory = new SweepstakesFactory();
            SweepstakesFactory.CreateSweepstakes();
        }
    }
}
