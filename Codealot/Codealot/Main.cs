using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Codealot
{
    class CodealotMain
    {
        static void Main(string[] args)
        {
            CodealotGame codealotGame = new CodealotGame();

            Random random = new Random(1);
            for (int i = 0; i < 24; ++i) {                
                foreach (Knight knight in codealotGame.Knights) {
                    int randomVal = random.Next(2);
                    if (randomVal == 0) {
                        knight.MoveToTrainingYard();
                    } else if (randomVal == 1) {
                        knight.MoveToTavern();
                    }
                    knight.ProcessHour();
                }                
            }
            codealotGame.GrantBonusXp();

            int totalXp = 0;
            foreach (Knight knight in codealotGame.Knights) {
                totalXp += knight.GetXp();
            }

            Console.WriteLine("Total XP earned by all " + codealotGame.Knights.Count + " knights: " + totalXp);
            Console.ReadKey();
        }        
    }
}
