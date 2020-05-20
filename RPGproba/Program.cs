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
            PrepareAndBattle.PopulateMonsterListSkeletons(SkeletonsList);

            List<BaseClass> MinotaursList = new List<BaseClass>();
            PrepareAndBattle.PopulateMonsterListMinotaurs(MinotaursList);

            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            Hero hero = new Hero(name);

            Story.ChooseAWeaponText();           
            PrepareAndBattle.ChooseAWeapon(hero);

            Story.Start(hero, SkeletonsList);

            PrepareAndBattle.Battle(hero, SkeletonsList);

            Story.WinOverSkeletons(hero, MinotaursList);

            PrepareAndBattle.Battle(hero, MinotaursList);

            Story.EndGame(hero);

        }
    }
                   
}

