using System;

namespace Adventurer.Models
{
    class ClericClass : BaseClass
    {
        public int Mana { get; set; }      

        Random random = new Random();
        static int id = 1;
        public ClericClass(string name)
        {
            this.Id = id++;
            this.Name = name;
            this.HealthPoints = random.Next(30, 60);
            this.Weapon = (Weapon)random.Next(0, 6);
            this.DamageCoefficient = 3;            
            this.Mana = random.Next(20, 30);
            this.IsAlive = true;
        }

        public void Heal(BaseClass friend, int maxHP)
        {
            int maxHp = friend.HealthPoints;
            int heal = random.Next(5, 15);

            if (friend.IsAlive)
            {              
                if (Mana >= 3)
                {
                    friend.HealthPoints = friend.HealthPoints + heal;
                    this.Mana = this.Mana - 3;
                    Console.WriteLine($"{this.Name} use heal on {friend.Name} and heal {heal} health points");

                    if(friend.HealthPoints > maxHp)
                    {
                        friend.HealthPoints = maxHp;
                    }
                }
                else
                {
                    Console.WriteLine("Not enough mana");
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} say: {friend.Name} is dead. I can't heal him.");                
            }
        }
    }
}
