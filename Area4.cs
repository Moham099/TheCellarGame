using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheCellarGame
{
    public class Area4
    {
        public static void area4Func(List<Player> playerList, List<Enemy> enemyList, int area4Counter)
        {
            double area4ID = 4.0;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("You enter a small chamber, its walls covered with piles of various items and trinkets.\nIn the corner you see a humanoid pack-rat gesteruing you to come closer.");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("CoME CLOseR HooMAn");
             Console.ResetColor();
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("As you approach the strange creature you see it pointing to two boxes, wrapped in what appeared to be oil and dirt stained linen");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("PiCk OnE....anD....ONLY..........ONE");
            Console.ResetColor();
            Console.WriteLine("\n");

            
            Console.Write("1.Pick the left, larger box\n2.Pick the right box\n3.Take both boxes\n>");

            
                int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Unbeknownst to you the disgusting creature in front of you was none other than Razznit, the God of the Rats.\nAs you attempt to grab both boxes, Razznit stands up in RAGE");
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("I! SAID! ONE!");
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("At that moment you realized you have made a grave mistake");
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    CombatSequence.combatSequenceFunc(playerList, enemyList, area4Counter, area4ID);
                    break;
                default:
                    break;
            }
        }
    }
}
