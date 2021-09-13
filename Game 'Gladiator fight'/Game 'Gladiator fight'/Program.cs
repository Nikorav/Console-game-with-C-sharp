using System;

namespace Game__Gladiator_fight_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float healthOne = rand.Next(90,100);
            int damageOne = rand.Next(5, 25);
            int armorOne = rand.Next(25, 65);
            float healthTwo = rand.Next(80, 150);
            int damageTwo = rand.Next(20, 40);
            int armorTwo = rand.Next(65, 100);

            Console.WriteLine($"Гладиатор 1 - {healthOne} хп, {damageOne} максимальный урон, {armorOne} броня");
            Console.WriteLine($"Гладиатор 2 - {healthTwo} хп, {damageTwo} максимальный урон, {armorTwo} броня");

            while (healthOne > 0 && healthTwo > 0)
            {
                healthOne -= Convert.ToSingle(rand.Next(0, damageTwo)) / 100 * armorOne;
                healthTwo -= Convert.ToSingle(rand.Next(0, damageOne)) / 100 * armorTwo;
                Console.WriteLine($"Гладиатор 1 - {healthOne}");
                Console.WriteLine($"Гладиатор 2 - {healthTwo}");
            }

            if(healthOne <= 0 && healthTwo <= 0)
            {
                Console.WriteLine("Ничья, Оба мертвы.");          
            } 
            else if(healthOne <= 0)
            {
                Console.WriteLine("Глабиатор 1 пал в бою.");
            }
            else if(healthTwo <= 0)
            {
                Console.WriteLine("Глабиатор 2 пал в бою.");
            }
        }
    }
}
