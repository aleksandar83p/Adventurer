using Adventurer.Models.Utils;
using System;
using System.Collections.Generic;


namespace Adventurer.Models
{
    public static class PrepareAndBattle
    {

        public static void PopulateMonsterListSkeletons(List<BaseClass> monsterList)
        {
            Random random = new Random();
            int SkeletonNumber = random.Next(3, 6);

            for (int i = 0; i < SkeletonNumber; i++)
            {
                Skeleton s = new Skeleton();
                monsterList.Add(s);
            }
        }

        public static void PopulateMonsterListMinotaurs(List<BaseClass> monsterList)
        {
            Random random = new Random();
            int MinotaurNumber = random.Next(2, 3);

            for (int i = 0; i < MinotaurNumber; i++)
            {
                Minotaur s = new Minotaur();
                monsterList.Add(s);
            }
        }

        public static void ChooseAWeapon(BaseClass hero)
        {
            int number = 0;
            do
            {
                number = IOclass.ChooseWeaponNumber();

            } while (number < 1 || number > 6);

            switch (number)
            {
                case 1:
                    hero.Weapon = Weapon.Dagger;
                    break;
                case 2:
                    hero.Weapon = Weapon.Sword;
                    break;
                case 3:
                    hero.Weapon = Weapon.Greatsword;
                    break;
                case 4:
                    hero.Weapon = Weapon.Mace;
                    break;
                case 5:
                    hero.Weapon = Weapon.Battleaxe;
                    break;
                case 6:
                    hero.Weapon = Weapon.Warhammer;
                    break;
                default:
                    Console.WriteLine("Please enter 1 - 6");
                    break;
            }
        }

        public static void Battle(BaseClass hero, List<BaseClass> mons)
        {

            Console.WriteLine($"{hero.Name}, Health Points: {hero.HealthPoints}");

            bool IsAlive = true;
            while (IsAlive)
            {
                Console.WriteLine("Izaberi opcije");
                foreach (var mon in mons)
                {
                    if (mon.IsAlive)
                    {
                        Console.WriteLine($"Press {mon.Id} to attack \"{mon.Name}\" (HP: {mon.HealthPoints}, Weapon: {mon.Weapon})");
                    }

                    if (!mon.IsAlive)
                    {
                        Console.WriteLine($"\"{mon.Name}\" is dead");
                    }
                }

                var keyPressed = IOclass.ReadNumber();

                if (keyPressed <= 0 || keyPressed > mons.Count)
                {
                    Console.WriteLine("You have entered wrong number. Please press number between 1 to " + mons.Count);
                }
                else
                {
                    if (mons[keyPressed - 1].IsAlive)
                    {
                        for (int i = 0; i < mons.Count; i++)
                        {
                            if (keyPressed - 1 == i)
                            {
                                hero.Attack(mons[i]);
                            }
                            else
                            {
                                Console.WriteLine($"{mons[0].Name} is dead");
                            }
                        }
                        foreach (var mon in mons)
                        {
                            if (mon.IsAlive)
                            {
                                mon.Attack(hero);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{mons[0].Name} is already dead. Choose next enemy");
                    }
                }


                if (hero.HealthPoints <= 0)
                {
                    Story.GameOver();
                    IsAlive = false;
                }

                var anyoneAlive = false;

                foreach (var monster in mons)
                {
                    if (monster.IsAlive)
                        anyoneAlive = true;
                }


                if (!anyoneAlive)
                {
                    IsAlive = false;
                }

                PrepareAndBattle.Battle(hero, mons);

                if (hero.HealthPoints <= 0)
                {
                    Story.GameOver();
                    IsAlive = false;
                }

                var anyoneAliveS = false;
                foreach (var monster in mons)
                {
                    if (monster.IsAlive)
                    {
                        anyoneAliveS = true;
                    }
                }


                if (!anyoneAliveS)
                {
                    Story.WinOverSkeletons(hero, mons);
                    anyoneAliveS = false;
                }
            }
        }
    }
}
