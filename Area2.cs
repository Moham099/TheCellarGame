using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheCellarGame
{
    public class Area2
    {
        public static void Area2Func(List<Player> playerList, List<Enemy> enemyList, int area2Counter)
        {
            double area2ID = 2.0;
            string enemyName = "";
            string enemyWeapon = "";
            int enemyAP = 0;

            enemyList.Add(new Enemy());
            foreach (Enemy a in enemyList)
            {
                enemyName = a.NameEn;
                enemyWeapon = a.WeaponNameEn;
                enemyAP = a.WeaponStrEn;

            }

            if (area2Counter == 0)
            {
                TextMod.NarrTF();
                Console.Write("\nYou venture further into what appears to be a small room in the cellar\nIt is quite dark and as you struggle to get your footing you hear the loud clamoring of\n" +
                    "items being knocked over as you feel somethign brush your pant leg.\nyou quickly light a torch and see a {0} staring back at you...prepare for combat.", enemyName);
                Console.ResetColor();
                Console.WriteLine("\n\nPress ANY button to continue");
                Console.ReadKey();
                CombatSequence.combatSequenceFunc(playerList, enemyList, area2Counter, area2ID);
                Console.WriteLine("\n");
                foreach (Player p in playerList)
                {
                    TextMod.StaTF();
                    Console.Write("Your remaining health is " + p.HealthPl);
                    Console.ResetColor();
                    Console.WriteLine("\n");
                }

            }
         
            if (area2Counter == 0)
            {
                TextMod.NarrTF();
                Console.Write("You defeated the {0}, it dropped {1}", enemyName, enemyWeapon);
                Console.ResetColor();
                Console.WriteLine("");
                if (enemyWeapon != "NOTHING")
                {
                    TextMod.NarrTF();
                    Console.Write("\nAs you strike your final blow the {0} slams into the wall behind you, , knocking over the large wine rack, blocking the path you came from. East. Is the only option.", enemyName);
                    Console.ResetColor();
                    Console.Write("\n1.Pick up the {0}\n2.Head East\n>", enemyWeapon);
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            TextMod.ActTF();
                            Console.WriteLine("You pick up the {0} and tuck it in your waistband", enemyWeapon);
                            Console.ResetColor();
                            foreach (Player a in playerList)
                            {
                                
                                    a.WeaponStrPl = enemyAP;
                                
                            }

                            foreach (var a in playerList)
                            {
                                TextMod.StaTF();
                                Console.WriteLine("PLAYER ATTACK STRENGTH IS NOW:{0}", a.WeaponStrPl);
                                Console.ResetColor();
                                Console.WriteLine("\npress ANY button to continue");
                            }
                            area2Counter++;
                            Area2.Area2Func(playerList, enemyList,area2Counter);
                            break;
                        case 2:
                            Console.Write("You head east");
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            area2Counter = 0;
                            Area4.area4Func(playerList, enemyList, area2Counter);
                            break;

                    }
                }
                else
                {
                    TextMod.NarrTF();
                    Console.Write("As you strike your final blow the {0} slams into the wall behind you, knocking over the large wine rack, blocking the path you came from. East. Is the only option.", enemyName);
                    Console.ResetColor();
                    Console.ReadKey();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    TextMod.ActTF();
                    Console.WriteLine("You head EAST");
                    Console.ResetColor();
                    Area4.area4Func(playerList, enemyList, area2Counter);
                  
                }
            }
           


        }
    }
}
