using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingSimulations
{
    public class GamblingCode
    {
        int betWon, betLost;
        int maxMoney = 100;
        int moneySpend = 1;
        Random random = new Random();
        public void GameWon()
        {
            if (betWon == 1)
            {
                Console.WriteLine("You have Won Bet");
            }
            else
            {
                Console.WriteLine("Play More");
            }
        }
        public void GameLost()
        {
            if (betLost == 0)
            {
                Console.WriteLine("You have Lost Bet");
            }
            if (maxMoney == 0)
            {
                Console.WriteLine("Dont Have Enough Money");
            }
        }
    }
}
