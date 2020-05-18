using Adventurer.Models;
using Adventurer.Models.Utils;
using System;
using System.Collections.Generic;


namespace Adventurer
{
    class Program
    {
        static void Main(string[] args)
        {         
            Game();
        }

        private static void Game()
        {
            Skeleton s1 = new Skeleton();
            Skeleton s2 = new Skeleton();
            Skeleton s3 = new Skeleton();
            Skeleton s4 = new Skeleton();
            Skeleton s5 = new Skeleton();

            Minotaur m1 = new Minotaur();
            Minotaur m2 = new Minotaur();

            List<BaseClass> monsters = new List<BaseClass>();
            monsters.Add(s1);
            monsters.Add(s2);
            monsters.Add(s3);
            monsters.Add(s4);
            monsters.Add(s5);

            List<BaseClass> monstersTwo = new List<BaseClass>();
            monstersTwo.Add(m1);
            monstersTwo.Add(m2);
            

            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            FighterClass h1 = new FighterClass(name);

            ClericClass heroMage = new ClericClass("Cleric");
            int maxHpH1 = h1.HealthPoints;
            

            Console.WriteLine("Choose a weapon");
            Console.WriteLine("1) Dagger(1-2 damage)\n2) Sword (1-4 damage)\n3) Greatsword (2-5 damage)\n4) Mace (2-3 damage)\n5) Battleaxe (2-4 damage)\n6) Warhammer (3-4 damage)\n");

            

            int number = 0;          
            do
            { 
                number = IOclass.ChooseNumber();
                
            } while (number < 1 || number > 6);

            switch (number)
            {
                case 1:
                    h1.Weapon = Weapon.Dagger;
                    break;
                case 2:
                    h1.Weapon = Weapon.Sword;
                    break;
                case 3:
                    h1.Weapon = Weapon.Greatsword;
                    break;
                case 4:
                    h1.Weapon = Weapon.Mace;
                    break;
                case 5:
                    h1.Weapon = Weapon.Battleaxe;
                    break;
                case 6:
                    h1.Weapon = Weapon.Warhammer;
                    break;                
                default:
                    Console.WriteLine("Please enter 1 - 6");
                    break;
            }

            Console.WriteLine($"**{h1.Name}, ({h1.HealthPoints} Health Points, Weapon: {h1.Weapon})**\n");
            Console.WriteLine($"**{heroMage.Name}, ({heroMage.Mana}) Mana Points, Weapon: {heroMage.Weapon} **\n");


            Console.WriteLine($"{h1.Name} was a farmer all his life who dreamed of becoming an adventurer.\nOne day {h1.Name} decided to buy {h1.Weapon} and embark on an adventure.");
            

            // Fight 1
            bool IsAlive = true;            
            Console.WriteLine($"{h1.Name} decided to go to the mountains. Behind the waterfall was a cave.\nAfter some time exploring the cave {h1.Name} ran into group of five skeletons.\nThe first skeleton jumps on him but {h1.Name} manages to avoid him.");
            while (IsAlive)
            {
                Console.WriteLine($"**{h1.Name}, ({h1.HealthPoints} Health Points, Weapon: {h1.Weapon})**\n");
                Console.WriteLine($"**{heroMage.Name}, ({heroMage.Mana}) Mana Points, Weapon: {heroMage.Weapon} **\n");

                HeroAttack(h1, monsters);

              


                //Console.WriteLine($"{h1.Name} napada!**********");
                //Console.WriteLine("Select options");
                //foreach (var mon in monsters)
                //{                    
                //    if (mon.IsAlive)
                //    {
                //        Console.WriteLine($"Press {mon.Id} to attack \"{mon.Name}\" (HP: {mon.HealthPoints}, Weapon: {mon.Weapon})");                        
                //    }

                //    if (!mon.IsAlive)
                //    {
                //        Console.WriteLine($"\"{mon.Name}\" is dead");
                //    }
                //}


                //switch (IOclass.ReadNumber())
                //{
                //    case 1:
                //        if (monsters[0].IsAlive)                        
                //        {                           
                //            h1.Attack(monsters[0]);
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{monsters[0].Name} is dead");
                //        }
                //        break;
                //    case 2:
                //        if (monsters[1].IsAlive)  
                //        {                            
                //            h1.Attack(monsters[1]);
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{monsters[1].Name} is dead");
                //        }
                //        break;
                //    case 3:
                //        if (monsters[2].IsAlive)
                //        {                            
                //            h1.Attack(monsters[2]);
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{monsters[2].Name} is dead");
                //        }
                //        break;
                //    case 4:
                //        if (monsters[3].IsAlive)
                //        {                           
                //            h1.Attack(monsters[3]);
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{monsters[3].Name} is dead");
                //        }
                //        break;
                //    case 5:
                //        if (monsters[4].IsAlive)
                //        {                           
                //            h1.Attack(monsters[4]);
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{monsters[4].Name} is dead");
                //        }
                //        break;
                //}

                foreach (var mon in monsters)
                {
                    if (mon.IsAlive)
                    {
                        mon.Attack(h1);
                    }
                }

                heroMage.Heal(h1, maxHpH1);               
                Console.WriteLine($"**{heroMage.Name}, (Mana Points: {heroMage.Mana}, Weapon: {heroMage.Weapon} **\n");
                Console.WriteLine($"**{h1.Name}, (Health Points: {h1.HealthPoints}, Weapon: {h1.Weapon})**\n");

                if (h1.HealthPoints == 0 || h1.HealthPoints < 0)
                {
                    Console.WriteLine("GAME OVER");
                    IsAlive = false;
                }

                if (!monsters[0].IsAlive && !monsters[1].IsAlive && !monsters[2].IsAlive && !monsters[3].IsAlive && !monsters[4].IsAlive)
                {
                    Console.WriteLine($"{h1.Name} he dealt with the skeletons. Suddenly a throaty voice was heard. What a noise there! Two Minotaurs jumped out of the darkness!");
                    IsAlive = false;
                }              

            }



            // Fight 2
            bool IsAliveM = true;            
            while (IsAliveM)
            {
                Console.WriteLine("Izaberi opcije");
                foreach (var mon in monstersTwo)
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


                switch (IOclass.ReadNumber())
                {
                    case 1:
                        if (monstersTwo[0].IsAlive)
                        {                            
                            h1.Attack(monstersTwo[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{monstersTwo[0].Name} is dead");
                        }
                        break;
                    case 2:
                        if (monstersTwo[1].IsAlive)
                        {                         
                            h1.Attack(monstersTwo[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{monstersTwo[1].Name} is dead");
                        }
                        break;                 

                }

                foreach (var mon in monstersTwo)
                {
                    if (mon.IsAlive)
                    {
                        mon.Attack(h1);
                    }
                }
                               

                if (h1.HealthPoints == 0 || h1.HealthPoints < 0)
                {
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("Please try again. Each new game gives the hero a different amount of health points.\nAlso, each new game gives enemies different weapons.");
                    IsAliveM = false;
                }

                if (!monstersTwo[0].IsAlive && !monstersTwo[1].IsAlive)
                {
                    Console.WriteLine($"{h1.Name} barely defeated the minotaurs. He has had enough of this cave and adventures for life. He decided to go outside and return to the farm.");
                    Console.WriteLine("THE END");
                    IsAliveM = false;
                }
            }            
        }   

        public static void HeroAttack(BaseClass hero, List<BaseClass> mons)
        {
            Console.WriteLine($"{hero.Name} napada!**********");
            Console.WriteLine("Select options");

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


            switch (IOclass.ReadNumber())
            {
                case 1:
                    if (mons[0].IsAlive)
                    {
                        hero.Attack(mons[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{mons[0].Name} is dead");
                    }
                    break;
                case 2:
                    if (mons[1].IsAlive)
                    {
                        hero.Attack(mons[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{mons[1].Name} is dead");
                    }
                    break;
                case 3:
                    if (mons[2].IsAlive)
                    {
                        hero.Attack(mons[2]);
                    }
                    else
                    {
                        Console.WriteLine($"{mons[2].Name} is dead");
                    }
                    break;
                case 4:
                    if (mons[3].IsAlive)
                    {
                        hero.Attack(mons[3]);
                    }
                    else
                    {
                        Console.WriteLine($"{mons[3].Name} is dead");
                    }
                    break;
                case 5:
                    if (mons[4].IsAlive)
                    {
                        hero.Attack(mons[4]);
                    }
                    else
                    {
                        Console.WriteLine($"{mons[4].Name} is dead");
                    }
                    break;
            }
        }
    }
}
