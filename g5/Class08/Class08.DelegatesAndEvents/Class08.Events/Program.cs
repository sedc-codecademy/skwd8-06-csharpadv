using System;
using System.Threading;

namespace Class08.Events
{
    class Program
    {

        static int Score = 0;
        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();

            shooter.KillingCompleted += KilledEnemy;
            shooter.KillingCompleted += AddScore;
          
            shooter.OnShoot();
           
        }

        public static void KilledEnemy(object sender,EventArgs e)
        {
            Console.WriteLine("I killed an enemy..");
            Console.WriteLine($"My score now is : {Score}");
        }

        public static void AddScore(object sender, EventArgs e)
        {
            Score++;
        }
    }

    internal class Shooter
    {
        public delegate void KillingHandler(object sender, EventArgs e);
        public event KillingHandler KillingCompleted;

        private Random rng = new Random();
        public void OnShoot()
        {
            while(true)
            {
                if(rng.Next(0,100) % 2 == 0)
                {
                    if(KillingCompleted != null)
                    {
                        KillingCompleted.Invoke(this, EventArgs.Empty);
                    }
                }
                else
                {
                    Console.WriteLine("I missed..");
                }

                Thread.Sleep(500);
            }
        }


    }


}
