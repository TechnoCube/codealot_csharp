using System;
using System.Collections;

namespace Codealot
{
    public class Codalot
    {
        // TODO: Move all knight logic internal so Main won't need access to them
        private ArrayList knights;
        public ArrayList Knights
        {
            get { return knights; }
        }

        /// <summary>
        /// Default constructor, creates a game with 12 knights
        /// </summary>
        public Codalot()
        {
            this.knights = new ArrayList();
            for (int i = 0; i < 12; ++i)
            {
                knights.Add(new Knight());
            }
        }

        /// <summary>
        /// Constructor for custom amount of knights
        /// </summary>
        /// <param name="numberOfKnights"></param>
        public Codalot(int numberOfKnights)
        {
            this.knights = new ArrayList();
            for (int i = 0; i < numberOfKnights; ++i)
            {
                knights.Add(new Knight());
            }
        }                

        public void addKnightToTrainingYard(Knight knight)
        {
            knight.setInTrainingYard(true);
            knight.setInTavern(false);
        }

        public void addKnightToTavern(Knight knight)
        {         
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