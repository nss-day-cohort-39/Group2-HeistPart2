using System;
using System.Collections.Generic;

namespace HeistPart2
{

    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void DisableAlarms() { }
        public void PerformSkill(Bank bank)
        {
            DisableAlarms();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}