using System;
using System.Collections.Generic;

namespace HeistPart2
{

    public class LockSpecialist: IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void CrackVaults(){}
        public void PerformSkill(Bank bank)
        {
            CrackVaults();
        }

         public override string ToString()
        {
            return $"{Name}";
        }

    }
}