using System;
using System.Collections.Generic;


namespace Adventurer.Models
{
    public static class Story
    {
        public static void ChooseAWeaponText()
        {
            Console.WriteLine("Choose a weapon");
            Console.WriteLine("1) Dagger(1-2 damage)\n2) Sword (1-4 damage)\n3) Greatsword (2-5 damage)\n" +
                "4) Mace (2-3 damage)\n5) Battleaxe (2-4 damage)\n6) Warhammer (3-4 damage)\n");
        }

        public static void Start(BaseClass hero, List<BaseClass> mons)
        {
            Console.Clear();

            Console.WriteLine($"{hero.Name} was a farmer all his life who dreamed of becoming an adventurer.\n" +
                $"One day {hero.Name} decided to buy {hero.Weapon} and embark on an adventure.\n" +
                $"{hero.Name} decided to go to the mountains. Behind the waterfall was a cave.\n" +
                $"After some time exploring the cave {hero.Name} ran into group of {mons.Count} skeletons.\n" +
                $"The first skeleton jumps on him but {hero.Name} manages to avoid him.");
        }    

        public static void WinOverSkeletons(BaseClass hero, List<BaseClass> mons)
        {
            Console.WriteLine($"{hero.Name} he dealt with the skeletons. Suddenly a throaty voice was heard.\nWhat a noise there! {mons.Count} Minotaurs jumped out of the darkness!");
        }

        public static void EndGame(BaseClass hero)
        {
            Console.WriteLine($"{hero.Name} barely defeated the minotaurs. He has had enough of this cave and adventures for life.\n{hero.Name} decided to go outside and return to the farm.");
            Console.WriteLine("THE END");
        }

        public static void GameOver()
        {
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Please try again. Each new game gives different amount of enemies.\nAlso, the hero a different amount of health points.");
        }
    }
}
