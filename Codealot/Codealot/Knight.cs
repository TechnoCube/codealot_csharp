using System;

namespace Codealot
{
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
            // If the knight is in the training yard and has stamina to train, increment xp and decrement stamina
            else if (IsInTrainingYard() && GetStamina() > 0)
            {
                IncrementStamina(-1);
                IncrementXp(1);
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
            is_InTavern = true;
            is_InTrainingYard = false;
        }

        /// <summary>
        /// Moves the knight to the training yard and out of all other locations
        /// </summary>
        public void MoveToTrainingYard()
        {
            is_InTrainingYard = true;
            is_InTavern = false;
        }

        public bool IsInTavern()
        {
            return this.is_InTavern;
        }        

        public bool IsInTrainingYard()
        {
            return this.is_InTrainingYard;
        }        
    }
}