using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSuperAwesomeCoolGame
{
    internal class Program
    {
        static int health;
        static int shield;
        static int lives;
        static int score;

        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------------->");
            Console.WriteLine("NEW Super Awesome Cool Game!!!!");
            Console.WriteLine("<----------------------------->");

            health = 100;
            shield = 100;
            lives = 3;
            score = 0;
            
        }
        static void ShowHUD()
        {

        }
    }
}
