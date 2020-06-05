using System;
using System.Collections.Generic;

namespace HeistPart2
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a new bank to rob
            Bank newHeist = new Bank();

            newHeist.bankRecon();

            Console.WriteLine();

            Hacker Heidi = new Hacker()
            {
                Name = "Heidi",
                SkillLevel = 50,
                PercentageCut = 10
            };
            Hacker Jayson = new Hacker()
            {
                Name = "Jayson",
                SkillLevel = 49,
                PercentageCut = 10
            };
            Muscle Sarah = new Muscle()
            {
                Name = "Heidi",
                SkillLevel = 50,
                PercentageCut = 10
            };
            Muscle Drew = new Muscle()
            {
                Name = "Drew",
                SkillLevel = 61,
                PercentageCut = 10
            };
            LockSpecialist Steve = new LockSpecialist()
            {
                Name = "Steve",
                SkillLevel = 90,
                PercentageCut = 10
            };
            LockSpecialist Mo = new LockSpecialist()
            {
                Name = "Mo",
                SkillLevel = 95,
                PercentageCut = 10
            };

            List<IRobber> rolodex = new List<IRobber>
            {
                Heidi,
                Jayson,
                Sarah,
                Drew,
                Steve,
                Mo
            };

            foreach (IRobber robber in rolodex)
            {
                Console.WriteLine(robber);
            }

            Console.WriteLine("Enter New Team Member's name");
            string newName = Console.ReadLine();

            while (newName != "")
            {

                Console.WriteLine($@"Choose a number for {newName}'s speciality : 
1) Hacker (Disables alarms)
2) Muscle (Disarms guards)
3) Lock Specialist (cracks vault)");

                int newSpeciality = Int32.Parse(Console.ReadLine());

                while (newSpeciality != 1 && newSpeciality != 2 && newSpeciality != 3)
                {
                    Console.WriteLine("Please choose a number 1-3 DUM DUM.");
                    Console.Write($"Enter {newName}'s speciality: ");
                    newSpeciality = Int32.Parse(Console.ReadLine());
                }

                Console.Write($"Enter {newName}'s skill level: ");
                int newSkillLevel = Int32.Parse(Console.ReadLine());

                while (newSkillLevel < 0)
                {
                    Console.WriteLine("Skill level has to be a postive number, please try again.");
                    Console.Write($"Enter {newName}'s skill level: ");
                    newSkillLevel = Int32.Parse(Console.ReadLine());
                }

                Console.Write($"Enter {newName}'s percentage cut: ");
                int newPercentageCut = Int32.Parse(Console.ReadLine());

                if (newSpeciality == 1)
                {
                    Hacker newHacker = new Hacker()
                    {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    PercentageCut = newPercentageCut
                    };
                    rolodex.Add(newHacker);

                }
                if (newSpeciality == 2)
                {
                    Muscle newMuscle = new Muscle()
                    {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    PercentageCut = newPercentageCut
                    };
                    rolodex.Add(newMuscle);

                }
                if (newSpeciality == 3)
                {
                    LockSpecialist newLockSpecialist = new LockSpecialist()
                    {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    PercentageCut = newPercentageCut
                    };
                    rolodex.Add(newLockSpecialist);
                }

                Console.WriteLine("Enter New Team Member's name or press Enter to see list of fellow robbers");
                newName = Console.ReadLine();
            }

            foreach (IRobber robber in rolodex)
            {
                Console.WriteLine(robber);
            }
        }

    }
}