using System;

namespace Turn_based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentLevel = 1;
            Hero hero = new Hero();
            Goblin monster = new Goblin(currentLevel);
            Console.WriteLine("Monster {0} - (LV{1}) appears.", monster.name, monster.level);
            Random random = new Random();

            while (hero.isDead() == false)
            {
                hero.Attack(monster);
                Console.WriteLine("Hero attacks Monster!!");
                Console.ReadLine();

                if(monster.isDead())
                {
                    hero.currentExp += 20;
                    Console.WriteLine("The monster is dead!!\n");
                    hero.LevelUp();
                    currentLevel++;
                    int randomNum = random.Next(1, 3);
                    if (randomNum == 1)
                        monster = new Goblin(currentLevel);
                    else
                        monster = new SpearGoblin(currentLevel);
                    Console.WriteLine("Monster {0} - (LV{1}) appears.", monster.name,monster.level);
                }
                else
                {
                    monster.Attack(hero);
                    Console.WriteLine("Monster attacks Hero!!");
                    Console.ReadLine();
                }

                if (hero.isDead() == false)
                {
                    Console.WriteLine("Hero health: " + hero.health + " HP");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("The Hero is Dead");
            Console.WriteLine("Sad music plays in background");
            Console.ReadLine();
        }
    }
}
