using System;

namespace dontgocrazy
{
    internal class Game
    {
        public static string hello = "Hello World";
        public int number2 = 60;
        public int num3 = 10;
        private Health health = new Health();
        private Random random = new Random();

        public void Main()
        {
            Initialize();
            health.Damage(random.Next(1, 5));
            health.Heal(random.Next(1, 5));
        }

        public void Initialize()
        {
        }

        /*
        public void SwitchPractice()
        {
            Console.WriteLine("Enter Pass Code Please");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Entrance Code Accepted");
                        break;

                    case 2:
                        Console.WriteLine("Entrance Code Denied");
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            catch (Exception F)
            {
                Console.WriteLine(F);
                Console.Clear();
                SwitchPractice();
            }
            Console.Clear();
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
                HP -= damage;
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
        */
    }
}