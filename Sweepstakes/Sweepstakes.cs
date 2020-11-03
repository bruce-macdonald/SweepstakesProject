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
        Random r = new Random();

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
            int winningNumber = r.Next(1, contestants.Count);
            return contestants[winningNumber];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            //print message(contestants.RegistrationNumber, Name)
            UserInterface.ShowMessage($"{contestant.FirstName}, {contestant.LastName},{contestant.EmailAddress}, {contestant.RegistrationNumber} ");
        }

    }



}
