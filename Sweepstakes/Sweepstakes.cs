using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get; set; }

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count + 1;
            contestants.Add(contestant.RegistrationNumber,contestant);
        }

        public Contestant PickWinner()
        {
            return new Contestant();
        }

        public void PrintContestantInfo(Contestant contestant)
        { 
        
        }

    }



}
