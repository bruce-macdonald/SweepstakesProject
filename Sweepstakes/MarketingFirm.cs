using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{  
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("What would you like to name this sweepstakes?"));

            CreateContestant(sweepstakes);

            _manager.InsertSweepstakes(sweepstakes);
        }

        public void CreateContestant(Sweepstakes sweepstakesToAddContestant)
        {
            Contestant newContestant = new Contestant();
            sweepstakesToAddContestant.RegisterContestant(newContestant);
        }

    }


}