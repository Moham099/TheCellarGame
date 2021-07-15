using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheCellarGame
{
    public class Area1
    {
        public static void Area1Func(List<Player> playerList, List<Enemy> enemyListA1, int counter)
        {
                    
            int area2Counter = 0;
            int area3Counter = 0;

            if (counter == 0)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Leaving the tavern after one too many Ales you find yourself stumbling into a dark cellar\non the ground you see a shimmering glint of what appears to be a DAGGER" +
                "\nto the EAST you see a dark and damp path, while to the SOUTH you see a dimly lit room, what do you do?");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("1.Pick up DAGGER\n2.Go EAST\n3.Go SOUTH\n>");

                int area1Input = int.Parse(Console.ReadLine());
                switch (area1Input)
                {
                    case 1:
                        TextMod.ActTF();
                        Console.WriteLine("You pick up the dagger and tuck it into your wastband\n");
                        Console.ResetColor();
                        foreach (Player a in playerList)
                        {
                            a.WeaponStrPl = 3;

                        }



                        foreach (var a in playerList)
                        {
                            TextMod.StaTF();
                            Console.WriteLine("PLAYER ATTACK STRENGTH IS NOW:{0}", a.WeaponStrPl);
                            Console.ResetColor();
                            Console.WriteLine("\n\npress ANY button to continue\n");
                        }

                        Console.ReadLine();
                        counter++;
                        Area1Func(playerList, enemyListA1, counter);
                        break;
                    case 2:
                        TextMod.ActTF();
                        Console.Write("You duck under some hanging vines and proceed EAST");
                        Console.ResetColor();
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Area2.Area2Func(playerList, enemyListA1, area2Counter);
                        break;
                    case 3:
                        TextMod.ActTF();
                        Console.WriteLine("As you walk SOUTH you notice a shadowy figure...");
                        Console.ResetColor();
                        counter = 0;
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Area3.Area3Func(playerList, enemyListA1, counter);
                        break;

                }
            }
            else if (counter != 0)
            {
                TextMod.NarrTF();
                Console.Write("to the EAST you see a dark and damp path, while to the SOUTH a crack in the wall conveniently big enough for you to fit through, what do you do?");
                Console.ResetColor();

                Console.Write("\n1.Go EAST\n2.Go SOUTH\n>");

                int area1Input = int.Parse(Console.ReadLine());

                switch (area1Input)
                {
                    case 1:
                        TextMod.ActTF();
                        Console.Write("You duck under some hanging vines and proceed EAST");
                        Console.ResetColor();
                        Console.WriteLine("\n\npress ANY button to continue\n");
                        Console.ReadLine();
                        break;
                    case 2:
                        TextMod.ActTF();
                        Console.WriteLine("As you walk SOUTH you notice a shadowy figure...\n\n press ANY button to continue");
                        Console.ResetColor();
                        area2Counter = 0;
                        Area3.Area3Func(playerList, enemyListA1, area2Counter);
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
