using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UnitTest
{
    class BasicCodalot : Codalot
    {
        private ArrayList knights;

        public BasicCodalot() {
            this.knights = new ArrayList();
            for (int i = 0; i < 6; ++i) {
                this.knights.Add(new Knight());
            }
        }

        public void setKnight(int id, KnightPosition position) {
            Knight knight = (Knight)this.knights[id];
            knight.setInTavern(false);
            knight.setInTrainingYard(false);
            switch (position) {
                case KnightPosition.TAVERN: {
                    knight.setInTavern(true);
                    break;
                }
                case KnightPosition.TRAINING_YARD: {
                    knight.setInTrainingYard(true);
                    break;
                }
            }
        }

        public void process() {
            foreach (Knight knight in this.knights) {
                knight.incrementStamina(knight.isInTavern() ? 1 : -1);
                knight.incrementXp(knight.isInTrainingYard() ? 1 : 0);
            }
        }

        public int calculateEarnedXp() {
            int total = 0;
            foreach (Knight knight in this.knights) {
                total += knight.getXp();
            }
            return total;
        }

        public void clearKnights() {
            this.knights.Clear();
        }

        public void addKnightToTrainingYard(Knight knight) {
            knights.Add(knight);
            knight.setInTrainingYard(true);
            knight.setInTavern(false);
        }

        public void addKnightToTavern(Knight knight) {
            knights.Add(knight);
            knight.setInTavern(true);
            knight.setInTrainingYard(false);
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

        public class Knight
        {
            private int xp;
            private int stamina;
            private bool is_InTavern;
            private bool is_InTrainingYard;

            public Knight()
            {
                xp = 0;
                stamina = 0;
            }

            public int getXp()
            {
                return xp;
            }

            public void setXp(int xp)
            {
                this.xp = xp;
            }

            public void incrementXp(int xp)
            {
                this.xp += xp;
            }

            public int getStamina()
            {
                return stamina;
            }

            public void setStamina(int stamina)
            {
                this.stamina = stamina;
            }

            public void incrementStamina(int stamina)
            {
                this.stamina += stamina;
            }

            public bool isInTavern()
            {
                return is_InTavern;
            }

            public void setInTavern(bool isInTavern)
            {
                this.is_InTavern = isInTavern;
            }

            public bool isInTrainingYard()
            {
                return is_InTrainingYard;
            }

            public void setInTrainingYard(bool isInTrainingYard)
            {
                this.is_InTrainingYard = isInTrainingYard;
            }
        }
    }
}
