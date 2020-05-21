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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{hero.Name} was a farmer all his life who dreamed of becoming an adventurer.\n" +
                $"One day {hero.Name} decided to buy {hero.Weapon} and embark on an adventure.\n" +
                $"{hero.Name} decided to go to the mountains. Behind the waterfall was a cave.\n");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            Console.WriteLine($"After some time exploring the cave {hero.Name} ran into a group of {mons.Count} {mons[0].CharacterType}s\n" +
                $"The first {mons[0].CharacterType} jumps to attack but {hero.Name} manages to avoid him.");
            Console.ResetColor();
        }    

        public static void WinOverSkeletons(BaseClass hero, List<BaseClass> monsDefeted, List<BaseClass> monsNew)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{hero.Name} dealt with {monsDefeted[0].CharacterType}s. Suddenly a throaty voice was heard.\n\"What is that noise over there?\"" +
                $"{monsNew.Count} {monsNew[0].CharacterType}s jumped out of the darkness!");
            Console.ResetColor();
        }

        public static void EndGame(BaseClass hero, List<BaseClass> mons)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{hero.Name} barely defeated the {mons[0].CharacterType}s. He has had enough of this cave and adventures for life.\n" +
                $"{hero.Name} decided to go outside and return to the farm.");
            Console.WriteLine("THE END");
            Console.ResetColor();
        }

        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Please try again. Each new game gives a different amount of enemies.\n" +
                "Also, the hero has a different amount of health points.\nIf the game is to difficult choose a stronger weapon.");
            Console.ResetColor();
        }
    }
}
