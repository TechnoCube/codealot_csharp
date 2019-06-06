using System;

namespace Codealot
{
    public class Knight
    {
        private int xp;
        private int stamina;
        private bool isInTavern;
        private bool isInTrainingYard;
        private bool isExhausted;

        public Knight()
        {
            xp = 0;
            stamina = 3;
            isExhausted = false;
        }

        /// <summary>
        /// Performs the appropriate actions for a knight depending on its location and stamina level
        /// </summary>
        public void ProcessHour()
        {
            // Increment stamina by 1 if the knight is in the tavern
            if (IsInTavern())
            {
                IncrementStamina(1);
            }
            // Train the knight if it is in the training yard
            else if (IsInTrainingYard())
            {
                train();
            }
        }

        public int GetXp()
        {
            return xp;
        }

        public void SetXp(int xp)
        {
            this.xp = xp;
        }

        public void IncrementXp(int xp)
        {
            this.xp += xp;
        }

        public int GetStamina()
        {
            return stamina;
        }

        public void SetStamina(int stamina)
        {
            this.stamina = stamina;
        }

        public void IncrementStamina(int stamina)
        {
            this.stamina += stamina;
        }

        /// <summary>
        /// Moves the knight to the tavern and out of all other locations
        /// </summary>
        public void MoveToTavern()
        {
            isInTavern = true;
            isInTrainingYard = false;
        }

        /// <summary>
        /// Moves the knight to the training yard and out of all other locations
        /// </summary>
        public void MoveToTrainingYard()
        {
            isInTrainingYard = true;
            isInTavern = false;
        }

        public bool IsInTavern()
        {
            return this.isInTavern;
        }        

        public bool IsInTrainingYard()
        {
            return this.isInTrainingYard;
        }

        public bool IsExhausted()
        {
            return this.isExhausted;
        }

        /// <summary>
        /// Process the knight's action if they are in the training yard
        /// </summary>
        private void train()
        {
            // If the knight tries to train with 0 stamina, it becomes exhausted and loses all xp
            if (stamina == 0)
            {
                SetXp(0);
                isExhausted = true;
            }

            // If the knight is not exhausted and has stamina, train normally
            else if (!isExhausted)
            {
                IncrementStamina(-1);
                IncrementXp(1);
            }
        }
    }
}