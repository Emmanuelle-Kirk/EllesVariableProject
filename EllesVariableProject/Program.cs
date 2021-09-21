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

            Console.WriteLine("Elle presents...");
            Console.WriteLine("Rootin' Tootin' Laser Shootin'");

            int lives;

            string name;
            name = "Barnaby"; //Player Name
            lives = 3;
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are a space cowboy.");


            float weaponHeat;
            float weaponDischarge;

            weaponHeat = 50.00f;
            Console.WriteLine("Weapon Heat: " + weaponHeat);
            weaponDischarge = 0.5f;
            Console.WriteLine("WEAPON FIRED!");
            Console.WriteLine("Weapon Heat: " + weaponHeat / weaponDischarge); //Weapon heats up from being fired

            int score;
            int points;

            points = 100;
            score = 0 + points; //Score goes up by the amount of points earned
            Console.WriteLine("Score: " + score);

            int multiplier;
            multiplier = 3; //Combo Multiplier

            Console.WriteLine("Three kill streak!");

            Console.WriteLine("Combo Achived!");
            Console.WriteLine("Score: " + points * multiplier);
            score = 0 + points * multiplier;
            Console.WriteLine("Four kill streak!");
            Console.WriteLine("Combo Achived!");
            Console.WriteLine("Score: " + score * multiplier);

            Console.WriteLine("YOU DIED");
            score = 0;
            lives = lives - 1;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);



            Console.ReadKey(true);
        }
    }
}
