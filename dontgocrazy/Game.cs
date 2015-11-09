using System;

namespace dontgocrazy
{
    internal class Game
    {
        // Single class game
        public static string hello = "Hello World";
        public int number2 = 60;
        public int num3 = 10;
        Random random = new Random();
        int HP;
        int Armor;

        public void Main()
        {
            Init();
            Damage(random.Next(1, 5));
            Heal(random.Next(1, 5));
        }

        public void Init()
        {
            HP = 20;
            Armor = 0;
        }

        public void LoopingPractice()
        {
            Console.WriteLine("Number input plz");
            try
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result is " + (number1 - number2));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            do
            {
                Console.WriteLine(hello);
                num3--;
            }
            while (num3 > 0);
            System.Threading.Thread.Sleep(1000);

            Console.Clear();
        }

        public void IfElsePractice(string type, int health, int damage)
        {
            if (type == "Damage")
            {
                Console.WriteLine("Oh No, you have received damage");
                Console.WriteLine("Your Health is now at: " + HP);
                Console.ReadKey();
            }
            else if (type == "Heal")
            {
                Console.WriteLine("Oh No! You seem to have recovered some health");
                HP += damage;
                Console.WriteLine("Your Health is now at: " + HP);
                Console.ReadKey();
            }
        }

        #region Health Stuff

        public void Damage(int damagedone){HP -= damagedone;}
        public void Heal(int healthgained) {HP += healthgained;}

        #endregion
    }
}