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
        static int exp;
        static int level;

        static void Main(string[] args)
        {
            health = 100;
            shield = 100;
            lives = 3;
            score = 0;
            exp = 0;
            level = 1;

           
           


            Console.WriteLine("<----------------------------->");
            Console.WriteLine("NEW Super Awesome Cool Game!!!!");
            Console.WriteLine("<----------------------------->");
            Console.ReadKey(true);
            Console.WriteLine();
            ShowHUD();

            Console.ReadKey(true);
            
        }
        static void ShowHUD()
        {
            string status;
            status = "";

            Console.WriteLine("<------------->");
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Health: " + health);

            if ((health == 100) && (health >=76))
            {
                status = "FINE AND DANDY";
            }
            if ((health <=75 ) && (health >=51))
            {
                status = "JUST A FLESH WOUND";
            }
            if ((health <=50) && (health >= 26))
            {
                status = "NOT LOOKING TOO GOOD";
            }
            if ((health <=26) && (health >= 1))
            {
                status = "ONE FOOT IN THE GRAVE";
            }
            if (health == 0)
            {
                status = "DEAD";
            }

            Console.WriteLine("Health Status: " + status);
            Console.WriteLine("Experience points: " + exp);
            Console.WriteLine("Lives: " + lives);


            Console.WriteLine("<------------->");
        }
        static void TakeDamage(int damage)
        {
            shield = shield - damage;
            if (shield < 0)
            {
                shield = 0;
            }
            if (health < 0)
            {
                health = 0;
            }
            

        }
        static void GainExp(int gainEXP)
        {
            exp = exp + gainEXP;
            if (exp >= 200)
            {
                exp = 0;
            }
        }
        static void Heal(int heal)
        {

        }
    }
}
