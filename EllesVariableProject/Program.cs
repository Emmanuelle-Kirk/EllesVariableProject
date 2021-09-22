using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllesVariableProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Intro Section

            Console.WriteLine("Elle presents...");
            Console.WriteLine("Rootin' Tootin' Laser Shootin'");
            
            //Setup Section

            int lives;
            int health;
            Console.WriteLine("Score: 0");
            health = 100;

            Console.WriteLine("Health: " + health);

            string name;
            name = "Barnaby"; //Player Name
            lives = 3;

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are a space cowboy.");

            int shield;

            shield = 20;
            Console.WriteLine("==================");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("==================");
            //Weapon Firing Section

            Console.WriteLine("Picked up WEAPON");

            float weaponHeat;
            float weaponDischarge;

            weaponHeat = 50.00f;

            Console.WriteLine("==================");
            Console.WriteLine("Weapon Heat: " + weaponHeat);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("==================");
            weaponDischarge = 0.5f;
            Console.WriteLine("WEAPON FIRED!");
            Console.WriteLine("==================");
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("==================");


            int score;
            int points;


            points = 100;
            score = 0 + points; //Score goes up by the amount of points earned

            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("==================");

            //Kill Streak Section

            int multiplier;
            multiplier = 3; //Combo Multiplier

            Console.WriteLine("Three kill streak!");

            Console.WriteLine("Combo Achived!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + points * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("==================");

            score = 0 + points * multiplier;
            Console.WriteLine("Four kill streak!");
            Console.WriteLine("Combo Achived!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("==================");

            // Sheild and Damage section

            int damage;
            int damageCritical;
            damage = 20;
            damageCritical = damage * 2; //Critical Hit

            Console.WriteLine("YOU'VE BEEN HIT! SHIELD BROKEN!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + (shield -damage));
            Console.WriteLine("==================");
            Console.WriteLine("HEALTH EXPOSED!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health:" + health);
            Console.WriteLine("==================");
            Console.WriteLine("YOU'VE BEEN HIT!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + (health - damage));
            Console.WriteLine("==================");
            health = health - damage;
            Console.WriteLine("YOU'VE BEEN HIT!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + (health - damage));
            Console.WriteLine("==================");
            health = health - damage;
            Console.WriteLine("YOU'VE BEEN HIT!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + (health - damage));
            Console.WriteLine("==================");
            health = health - damage;
            Console.WriteLine("YOU'VE BEEN HIT! CRITICAL HIT!");
            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score * multiplier);
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + (health - damageCritical));
            Console.WriteLine("==================");
            health = health - damageCritical;
            //Death Section

            Console.WriteLine("YOU DIED");
            score = 0;
            lives = lives - 1;

            Console.WriteLine("==================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("==================");



            Console.ReadKey(true);
        }
    }
}
