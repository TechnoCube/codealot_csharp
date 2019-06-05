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
            return this.is_InTavern;
        }

        public void setInTavern(bool isInTavern)
        {
            this.is_InTavern = isInTavern;
        }

        public bool isInTrainingYard()
        {
            return this.is_InTrainingYard;
        }

        public void setInTrainingYard(bool isInTrainingYard)
        {
            this.is_InTrainingYard = isInTrainingYard;
        }
    }
}