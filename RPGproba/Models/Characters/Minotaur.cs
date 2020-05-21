using System;

namespace Adventurer.Models
{
    class Minotaur : BaseClass
    {
        public int Stamina { get; set; }

        Random random = new Random();
        static int id = 1;
        static int num = 1;
        public Minotaur()
        {
            this.Id = id++;
            this.Name = $"Minotaur {num++}";
            this.HealthPoints = random.Next(20, 30);
            this.Weapon = (Weapon)random.Next(0, 6);
            this.DamageCoefficient = 2;
            this.Stamina = random.Next(10, 20);
            this.CharacterType = CharacterType.Minotaur;
            this.IsAlive = true;
        }

        public void Rush(BaseClass enemy)
        {
            int rush = random.Next(10, 20);
            if (enemy.IsAlive)
            {
                if (Stamina >= 3)
                {
                    Console.WriteLine($"{this.Name} use Rush on {enemy.Name} and make {rush} damage");
                    enemy.HealthPoints = enemy.HealthPoints - rush;
                    this.Stamina = this.Stamina - 3;

                    if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                    {
                        enemy.IsAlive = false;
                        Console.WriteLine(enemy.Name + " is dead.");
                    }
                }
                else
                {
                    Console.WriteLine("Not enough stamina");
                }
            }
        }
    }
}
