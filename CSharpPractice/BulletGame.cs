using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class BulletGame
    {

        static int heroBullets = 100;
        static int villainBullets = 100;
        static void heroShoot()
        {
            heroBullets--;
        }
        static void villainShoot()
        {
            villainBullets = villainBullets - 3;
        }
        static void display()
        {
            Console.WriteLine("hero's balance : " + heroBullets);
            Console.WriteLine("villain's balance : " + villainBullets);
        }

        static void Bullet(string[] args)       //change to main before executing XXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        {
            bool next = true;
            while (next)
            {
                Console.WriteLine("who want to take shot hero , villain , exit for quit :");
                string key = Console.ReadLine();
                if (key == "hero")
                {
                    heroShoot();
                }
                else if (key == "villain")
                {
                    villainShoot();
                }
                else if (key == "exit")
                {
                    next = false;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                display();
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }
        }

    }
}
