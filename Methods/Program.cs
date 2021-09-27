using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{ // declarations
    
    class Program
    {
        static int score;
        static string name;
        static int xp;
        static int gold;
        // this method should be done down 
        static void ShowHUD() // method that shows the hud
        {
            Console.WriteLine("score =" + score);
            Console.WriteLine("name = " + name);
            Console.WriteLine("xp = " + xp);
            Console.WriteLine("gold = " + gold);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Methods: 
            // (AKA Procedures, Functions, etc.)
            Console.WriteLine("Methods:");
            

            //...

            // initialize
            score = 0;
            name = "Musu";
            xp = 0;
            gold = 0;

            // hud
            // THIS HUD IS BAD, only for demontration
            Console.WriteLine();
            ShowHUD();

            // simulated gameplay
            score = score + 100;
            xp = xp + 50;

            ShowHUD();
            score = score + 1000;
            xp = xp + 520;
            ShowHUD();

            Console.ReadKey(true);
        }
    }
}
