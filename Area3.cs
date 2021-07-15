using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheCellarGame
{
    class Area3
    {
        public static void Area3Func(List<Player> playerList, List<Enemy> enemyList, int area3Counter)
        {
            double area3ID = 3.0;
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
            TextMod.ActTF();
            Console.Write("Crawling through the hole in the wall the shadowy figure lunges towards you...");
            Console.ResetColor();
            CombatSequence.combatSequenceFunc(playerList, enemyList, area3Counter, area3ID);
            
            if (area3Counter == 0)
            {
                if (enemyWeapon != "NOTHING")
                {
                    TextMod.NarrTF();
                    Console.Write("As you strike your final blow the {0} slams into the wall behind you, knocking over the large wine rack, blocking the path you came from. East. Is the only option.", enemyName);
                    Console.ResetColor();
                    Console.WriteLine("1.Pick up the {0}\n2.Head East", enemyWeapon);
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("You pick up the {0} and tuck it in your waistband", enemyWeapon);
                            Console.ResetColor();
                            //int a = playerList.IndexOf()
                            foreach (Player a in playerList)
                            {
                                   a.WeaponStrPl = enemyAP;

                            }

                            foreach (var a in playerList)
                            {
                                TextMod.StaTF();
                                Console.WriteLine("PLAYER ATTACK STRENGTH IS NOW:{0}\n\npress ANY button to continue\n\n ", a.WeaponStrPl);
                                Console.ResetColor();
                            }
                            area3Counter++;
                            Area3Func(playerList, enemyList, area3Counter);
                            break;
                        case 2:
                            Console.Write("You head east");
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            area3Counter = 0;
                            Area4.area4Func(playerList, enemyList, area3Counter);
                            break;

                    }



                }
            }
        }
    }
}

