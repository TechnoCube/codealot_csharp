using System;
using System.Collections;
using System.Collections.Generic;

namespace Codealot
{
    public class CodealotGame
    {
        // TODO: Move all knight logic internal so Main won't need access to them
        private List<Knight> knights;
        public List<Knight> Knights
        {
            get { return knights; }
        }

        /// <summary>
        /// Default constructor, creates a game with 12 knights
        /// </summary>
        public CodealotGame()
        {
            this.knights = new List<Knight>();
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
            this.knights = new List<Knight>();
            for (int i = 0; i < numberOfKnights; ++i)
            {
                knights.Add(new Knight());
            }
        } 

        /// <summary>
        /// For every knight that earns five or more xp in a day, grant bonus xp equal to the total number
        /// of knights that earned five or more xp that day
        /// </summary>
        public void GrantBonusXp()
        {
            // Determine the bonus amount
            int bonusAmount = 0;
            foreach (Knight knight in this.knights)
            {
                if (knight.GetXp() >= 5)
                {
                    bonusAmount++;
                }
            }
            
            // Award the bonus amount to all eligible knights
            foreach (Knight knight in this.knights)
            {
                if (knight.GetXp() >= 5)
                {
                    knight.IncrementXp(bonusAmount);
                }
            }
        }
    }
}