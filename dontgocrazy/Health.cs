using System;

namespace dontgocrazy
{
    internal class Health
    {
        public static int HP = 10;

        public void health()
        {
            Initialize();
        }

        public void Initialize()
        {
        }

        public void Damage(int damage)
        {
            HP -= damage;
            Console.WriteLine("You took {0} damage. Your current health is {1}.", damage, HP);
            Console.ReadKey();
        }

        public void Heal(int gain)
        {
            HP += gain;
            Console.WriteLine("You gained {0} health. Your current health is {1}.", gain, HP);
            Console.ReadKey();
        }
    }
}