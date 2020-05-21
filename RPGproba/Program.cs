using Adventurer.Models;
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
            List<BaseClass> SkeletonsList = new List<BaseClass>();
            PrepareAndBattle.PopulateMonsterList(SkeletonsList, CharacterType.Skeleton);

            List<BaseClass> MinotaursList = new List<BaseClass>();
            PrepareAndBattle.PopulateMonsterList(MinotaursList, CharacterType.Minotaur);

            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            Hero hero = new Hero(name);

            Story.ChooseAWeaponText();           
            PrepareAndBattle.ChooseAWeapon(hero);

            Story.Start(hero, SkeletonsList);
            
            if (hero.IsAlive)
            {
                PrepareAndBattle.Battle(hero, SkeletonsList);
            }

            if (hero.IsAlive)
            {
                Story.WinOverSkeletons(hero, SkeletonsList, MinotaursList);
            }

            if (hero.IsAlive)
            {
                PrepareAndBattle.Battle(hero, MinotaursList);
            }

            if (hero.IsAlive)
            {
                Story.EndGame(hero, MinotaursList);
            }
            
        }
    }                   
}

