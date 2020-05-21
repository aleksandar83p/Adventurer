using System;

namespace Adventurer.Models
{
    class Skeleton : BaseClass
    {
        static int id = 1;
        static int num = 1;
        public Skeleton()
        {
            Random random = new Random();

            this.Id = id++;
            this.Name = $"Skeleton {num++}";           
            this.HealthPoints = random.Next(1, 10); 
            this.Weapon = (Weapon)random.Next(0, 6);
            this.DamageCoefficient = 1;
            this.CharacterType = CharacterType.Skeleton;
            this.IsAlive = true;

        }
    }
}
