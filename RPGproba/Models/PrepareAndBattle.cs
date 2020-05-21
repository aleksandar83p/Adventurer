using Adventurer.Models.Utils;
using System;
using System.Collections.Generic;


namespace Adventurer.Models
{
    public static class PrepareAndBattle
    {

        public static void PopulateMonsterList(List<BaseClass> monsterList, CharacterType monster)
        {
            Random random = new Random();

            if (monster == CharacterType.Skeleton)
            {
                int SkeletonNumber = random.Next(3, 6);

                for (int i = 0; i < SkeletonNumber; i++)
                {
                    Skeleton s = new Skeleton();
                    monsterList.Add(s);
                }
            }
            else if (monster  == CharacterType.Minotaur)
            {
                int MinotaurNumber = random.Next(2, 3);

                for (int i = 0; i < MinotaurNumber; i++)
                {
                    Minotaur s = new Minotaur();
                    monsterList.Add(s);
                }
            }          
        }

        public static void ChooseAWeapon(Hero hero)
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

        public static void Battle(Hero hero, List<BaseClass> mons)
        {           
            bool IsAlive = true;
            int round = 1;
            while (IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Round {round} VS {mons[0].CharacterType}s");
                Console.ResetColor();
                
                hero.Stats();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose who to attack:");
                Console.ResetColor();
                foreach (var mon in mons)
                {
                    if (mon.IsAlive)
                    {
                        Console.WriteLine($"Press {mon.Id} to attack \"{mon.Name}\" (HP: {mon.HealthPoints}, Weapon: {mon.Weapon})");                       
                    }

                    if (!mon.IsAlive)
                    {                        
                        Console.WriteLine($"\"{mon.Name}\" is dead.");                        
                    }
                }

                var keyPressed = IOclass.ReadNumber();

                if (keyPressed <= 0 || keyPressed > mons.Count)
                {                    
                    Console.WriteLine($"You have entered wrong number. Please press number between 1 to {mons.Count}.");                   
                    round--;
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{mons[keyPressed-1].Name} is already dead. Choose other enemy.");
                        Console.ResetColor();
                        round--;
                    }
                }

                
                if (hero.HealthPoints <= 0)
                {
                    Story.GameOver();
                    IsAlive = false;
                }
                else
                {
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
                }
                round++;
            }
        }
    }
}
