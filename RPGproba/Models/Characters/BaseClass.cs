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
        public CharacterType CharacterType { get; set; }
        public bool IsAlive { get; set; }

       public virtual void Stats()
       {
            Console.WriteLine($"Name: {this.Name} - Health: {this.HealthPoints} - Weapon: {this.Weapon}");
       }

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
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");
                        Console.ResetColor();

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;                            
                            Console.WriteLine(enemy.Name + " is dead.\n");
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.\n");                            
                        }
                    }
                    break;


                case Weapon.Greatsword:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(2, 5);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");
                        Console.ResetColor();

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.\n");                            
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.\n");                            
                        }

                    }
                    break;

                case Weapon.Mace:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(2, 3);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");
                        Console.ResetColor();

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.\n");                            
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.\n");                            
                        }
                    }

                    break;

                case Weapon.Dagger:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(1, 2);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");
                        Console.ResetColor();

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.\n");                            
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.\n");                            
                        }
                    }

                    break;

                case Weapon.Battleaxe:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(2, 4);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");
                        Console.ResetColor();

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.\n");                            
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.\n");                            
                        }
                    }

                    break;

                case Weapon.Warhammer:
                    if (enemy.IsAlive)
                    {
                        dmg = random.Next(3, 4);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{this.Name} attack with {this.Weapon} and make {dmg * DamageCoefficient} damage to \"{enemy.Name}\"");
                        Console.ResetColor();

                        enemy.HealthPoints = enemy.HealthPoints - dmg * this.DamageCoefficient;
                        if (enemy.HealthPoints == 0 || enemy.HealthPoints < 0)
                        {
                            enemy.IsAlive = false;
                            Console.WriteLine(enemy.Name + " is dead.\n");                            
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name} left {enemy.HealthPoints} HP.\n");                          
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Error\n");
                    break;
            }
        }
    }
}
