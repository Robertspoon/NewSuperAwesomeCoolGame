﻿using System;
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
        static int weapon;

        static void Main(string[] args)
        {
            health = 100;
            shield = 100;
            lives = 3;
            score = 0;
            exp = 0;
            level = 1;
            weapon = 0;

           
           


            Console.WriteLine("<----------------------------->");
            Console.WriteLine("NEW Super Awesome Cool Game!!!!");
            Console.WriteLine("<----------------------------->");
            Console.ReadKey(true);
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("You encountered an enemy goblin!");
            Console.WriteLine("The goblin strikes you, halving your shield");
            TakeDamage(50);
            Console.ReadKey(true);
            ShowHUD();
            Console.WriteLine("You strike the goblin with your sword, killing it instantly!");
            AddScore(50);
            GainExp(50);
            Console.ReadKey(true);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("You find a shield restoration unit, replenishing your shield!");
            RegenerateShield(100);
            Console.ReadKey(true);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("You encounter a Rock Golem!!");
            Console.WriteLine("You try to strike it with your sword, but it has so affect!!!");
            Console.WriteLine("The golem strikes you, depleating your shield and then some!!");
            TakeDamage(80);
            Console.ReadKey(true);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("You switch to your flail and strike the golem, dealing a decent blow on it!");
            SwitchWeapon(3);
            Console.ReadKey(true);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("The golem is still standing though, and strikes you again!");
            TakeDamage(80);
            Console.ReadKey(true);
            ShowHUD();
            Console.WriteLine("With a valiant swing of your flail, you hit the rock golem, destroying it!!");
            AddScore(200);
            GainExp(300);
            Console.ReadKey(true);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("You find a healing unit, restoring your H.P. to full!");
            Heal(150);
            Console.ReadKey(true);
            ShowHUD();
            Console.ReadKey(true);





            Console.ReadKey(true);
            
        }
        static void ShowHUD()
        {
            string status;
            status = "";
            string weaponName;
            weaponName = "";
           

            Console.WriteLine("<------------->");
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Health: " + health);

            if ((health <= 100) && (health >=76))
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

            if (weapon == 1)
            {
                weaponName = "Pistol";
            }
            else if (weapon ==2)
            {
                weaponName = "ShotGun";
            }
            else if (weapon ==3)
            {
                weaponName = "Flail";
            }
            else if (weapon ==4)
            {
                weaponName = "Proton Collider";
            }
            else
            {
                weaponName = "Sword";
            }

            Console.WriteLine("Health Status: " + status);
            Console.WriteLine("Current Weapon: " + weaponName);
            Console.WriteLine("Experience points: " + exp);
            Console.WriteLine("Lives: " + lives);


            Console.WriteLine("<------------->");
        }
        static void TakeDamage(int damage)
        {
            Console.WriteLine("You are about to take " + damage + " damage");
            shield = shield - damage;
            if (shield <0)
            {
                health += shield;
                shield = 0;
            }
            if (health <= 0)
            {
                Console.WriteLine("YOU DIED");
                lives--;
                GameOver();
            }


        }
        static void GainExp(int gainEXP)
        {
            exp = exp + gainEXP;
            if (exp >= 500)
            {

                exp -= 500;
                level = level + 1;
            }
        }
        static void Heal(int heal)
        {
            health = health + heal;
            if (health >100)
            {
                health = 100;
            }
           


        }
        static void RegenerateShield(int regenShield)
        {
            shield = shield + regenShield;
            if(shield >100)
            {
                shield = 100;
            }
            

        }
        static void Death()
        {
            if (health <=0)
            {
                Console.WriteLine("YOU DIED");
                lives --;
                GameOver();
            }
        }
        static void GameOver()
        {
            if (lives == 0)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Final score: " + score);
            }
        }
        static void Reset()
        {
            health = 100;
            shield = 100;
            lives = 3;
            exp = 0;
            level = 1;
            score = 0;
            weapon = 0;
        }
        static void AddScore(int upScore)
        {
            score = score + upScore;
        }
        static void SwitchWeapon(int changeWeapon)
        {
            weapon = changeWeapon;
        }
    }
}
