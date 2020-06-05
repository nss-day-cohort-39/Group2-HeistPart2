using System;
using System.Collections.Generic;

namespace HeistPart2
{

    public class Muscle: IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void DisarmGuards(){}
        public void PerformSkill(Bank bank)
        {
            DisarmGuards();
        }
      
         public override string ToString()
        {
            return $"{Name}";
        }

    }
}