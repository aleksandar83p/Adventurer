using System;

namespace Adventurer.Models
{
    public class Hero : BaseClass
    {        
        public int Stamina { get; set; }

        Random random = new Random();
        static int id = 1;
        public Hero(string name)
        {
            this.Id = id++;
            this.Name = name;
            this.HealthPoints = random.Next(50, 60);
            this.Weapon = (Weapon)random.Next(0, 6);
            this.DamageCoefficient = 3;
            this.Stamina = random.Next(10, 20);
            this.CharacterType = CharacterType.Hero;
            this.IsAlive = true;
        }

        public override void Stats()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{this.Name} - Health Points: {this.HealthPoints} - Weapon: {this.Weapon}");
            Console.ResetColor();
        }

        

        public void PowerBash(BaseClass enemy)
        {
            int bash = random.Next(20, 30);
            if (enemy.IsAlive)
            {
                if (Stamina >= 3)
                {
                    Console.WriteLine($"{this.Name} use Power Bash on {enemy.Name} and make {bash} damage");  
                    enemy.HealthPoints = enemy.HealthPoints - bash;
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
