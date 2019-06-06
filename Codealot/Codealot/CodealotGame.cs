using System;
using System.Collections;

namespace Codealot
{
    public class CodealotGame
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
        public CodealotGame()
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
        public CodealotGame(int numberOfKnights)
        {
            this.knights = new ArrayList();
            for (int i = 0; i < numberOfKnights; ++i)
            {
                knights.Add(new Knight());
            }
        } 

        public void GrantBonusXp()
        {
            int bonusKnights = 0;
            foreach (Knight knight in this.knights)
            {
                if (knight.GetXp() >= 3)
                {
                    bonusKnights++;
                }
            }
            if (bonusKnights == 3)
            {
                foreach (Knight knight in this.knights)
                {
                    if (knight.GetXp() >= 3)
                    {
                        knight.SetXp(knight.GetXp() + 5);
                    }
                }
            }
            if (bonusKnights == 5)
            {
                foreach (Knight knight in this.knights)
                {
                    if (knight.GetXp() >= 3)
                    {
                        knight.SetXp(knight.GetXp() + 10);
                    }
                }
            }
            if (bonusKnights == 6)
            {
                foreach (Knight knight in this.knights)
                {
                    if (knight.GetXp() >= 3)
                    {
                        knight.SetXp(knight.GetXp() + 20);
                    }
                }
            }
        }
    }
}