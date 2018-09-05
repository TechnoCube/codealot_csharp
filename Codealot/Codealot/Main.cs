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
            Codalot codalot = new Codalot();

            ArrayList knights = new ArrayList();
            for (int i = 0; i < 6; ++i) {
                knights.Add(new Knight());
            }

            Random random = new Random(1);
            for (int i = 0; i < 24; ++i) {
                codalot.clearKnights();
                foreach (Knight knight in knights) {
                    int randomVal = random.Next(2);
                    if (randomVal == 0) {
                        codalot.addKnightToTrainingYard(knight);
                    } else if (randomVal == 1) {
                        codalot.addKnightToTavern(knight);
                    }
                }
                codalot.process();
            }
            codalot.grantBonusXp();

            int totalXp = 0;
            foreach (Knight knight in knights) {
                totalXp += knight.getXp();
            }

            Console.WriteLine("Total XP earned by all " + knights.Count + " knights: " + totalXp);
        }

        public class Knight 
        {
            private int xp;
            private int stamina;
            private bool is_InTavern;
            private bool is_InTrainingYard;

            public Knight() {
                xp = 0;
                stamina = 0;
            }

            public int getXp() {
                return xp;
            }

            public void setXp(int xp) {
                this.xp = xp;
            }

            public void incrementXp(int xp) {
                this.xp += xp;
            }

            public int getStamina() {
                return stamina;
            }

            public void setStamina(int stamina) {
                this.stamina = stamina;
            }

            public void incrementStamina(int stamina) {
                this.stamina += stamina;
            }

            public bool isInTavern() {
                return this.is_InTavern;
            }

            public void setInTavern(bool isInTavern) {
                this.is_InTavern = isInTavern;
            }

            public bool isInTrainingYard() {
                return this.is_InTrainingYard;
            }

            public void setInTrainingYard(bool isInTrainingYard) {
                this.is_InTrainingYard = isInTrainingYard;
            }
        }

        public class Codalot
        {
            private ArrayList knights;

            public Codalot()
            {
                this.knights = new ArrayList();
            }

            public void clearKnights()
            {
                this.knights.Clear();
            }

            public void addKnightToTrainingYard(Knight knight)
            {
                this.knights.Add(knight);
                knight.setInTrainingYard(true);
                knight.setInTavern(false);
            }

            public void addKnightToTavern(Knight knight)
            {
                this.knights.Add(knight);
                knight.setInTavern(true);
                knight.setInTrainingYard(false);
            }

            public void process()
            {
                foreach (Knight knight in this.knights)
                {
                    knight.incrementStamina(knight.isInTavern() ? 1 : -1);
                    knight.incrementXp(knight.isInTrainingYard() ? 1 : 0);
                }
            }

            public void grantBonusXp()
            {
                int bonusKnights = 0;
                foreach (Knight knight in this.knights)
                {
                    if (knight.getXp() >= 3)
                    {
                        bonusKnights++;
                    }
                }
                if (bonusKnights == 3)
                {
                    foreach (Knight knight in this.knights)
                    {
                        if (knight.getXp() >= 3)
                        {
                            knight.setXp(knight.getXp() + 5);
                        }
                    }
                }
                if (bonusKnights == 5)
                {
                    foreach (Knight knight in this.knights)
                    {
                        if (knight.getXp() >= 3)
                        {
                            knight.setXp(knight.getXp() + 10);
                        }
                    }
                }
                if (bonusKnights == 6)
                {
                    foreach (Knight knight in this.knights)
                    {
                        if (knight.getXp() >= 3)
                        {
                            knight.setXp(knight.getXp() + 20);
                        }
                    }
                }
            }
        }
    }
}
