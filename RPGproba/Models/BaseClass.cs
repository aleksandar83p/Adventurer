using System;


namespace Adventurer.Models
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public Weapon Weapon { get; set; }
        public int DamageCoefficient { get; set; }
        public bool IsAlive { get; set; }

       

        public void Attack(BaseClass enemy)
        {
            Random random = new Random();
            int dmg = 0;
            switch (Weapon)
            {
                case Weapon.Sword:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(1, 4);
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");                 
                       
                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.");
                            Console.WriteLine();
                        }
                    }
                    break;


                case Weapon.Greatsword:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(2, 5);
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.");
                            Console.WriteLine();
                        }

                    }
                    break;

                case Weapon.Mace:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(2, 3);
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.");
                            Console.WriteLine();
                        }
                    }

                    break;

                case Weapon.Dagger:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(1, 2);
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.");
                            Console.WriteLine();
                        }
                    }

                    break;

                case Weapon.Battleaxe:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(2, 4);
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.");
                            Console.WriteLine();
                        }
                    }

                    break;

                case Weapon.Warhammer:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(3, 4);
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.");
                            Console.WriteLine();
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
      
    }
}
