using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingSimulations
{
    public class GamblingCode
    {
        //UC1
        int betWon, betLost;
        int maxMoney = 100;//not constant
        int moneySpend = 1;//constant
        Random random = new Random();
        //UC2
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
