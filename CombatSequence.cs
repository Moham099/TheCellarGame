using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheCellarGame
{
    public class CombatSequence
    {
        public static void combatSequenceFunc(List<Player> playerList, List<Enemy> enemyList, int counter, double areaID)
        {
            int playerHP = 0;
            int enemyHP = 0;
            int playerAP = 0;
            int enemyAP = 0;
            string enemyName = "";
            string enemyWeapon = "";
            counter++;
            foreach (Player p in playerList)
            {
                playerHP = p.HealthPl;
                playerAP = p.WeaponStrPl;
            }

            foreach (Enemy e in enemyList)
            {
                enemyName = e.NameEn;
                enemyHP = e.HealthEn;
                enemyAP = e.WeaponStrEn;
                enemyWeapon = e.WeaponNameEn;
            }

            if(areaID == 4.0)
            {
                enemyName = "The Rat God RAZZNIT";
                enemyHP = 20;
                enemyAP = 5;
                enemyWeapon = "Poison Claws";
            }
            Console.WriteLine("\n");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            TextMod.ActTF();
            Console.Write("You square up to the {0} and begin your attacks", enemyName);
            Console.ResetColor();
            Console.WriteLine("\n");
            Thread.Sleep(TimeSpan.FromSeconds(1));

            Random critChance = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                if (critChance.Next(1, 7) > 1)
                {
                    TextMod.AtkTF();
                    Console.WriteLine("You hit the {0} for {1} damage\n", enemyName, playerAP);
                    Console.ResetColor();
                    enemyHP -= playerAP;
                    foreach (Enemy e in enemyList)
                    {
                        e.HealthEn = enemyHP;
                        Console.WriteLine("ENEMY HEALTH: " + enemyHP);
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (enemyHP <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    TextMod.CritTF();
                    Console.Write("CRITICAL HIT!! You damage {0} for {1} damage", enemyName, playerAP * 2);
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    enemyHP -= playerAP * 2;
                    foreach (Enemy e in enemyList)
                    {
                        e.HealthEn = enemyHP;
                        Console.WriteLine("ENEMY HEALTH: " + enemyHP);
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (enemyHP <= 0)
                    {
                        break;
                    }
                }

                if (critChance.Next(1, 7) > 1)
                {
                    TextMod.AtkTF();
                    Console.WriteLine("{0} hits you for {1} damage\n", enemyName, enemyAP);
                    Console.ResetColor();
                    playerHP -= enemyAP;
                    foreach (Player p in playerList)
                    {
                        p.HealthPl = playerHP;
                        Console.WriteLine("PLAYER HEALTH: " + playerHP);
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (playerHP <= 0)
                    {
                        Console.WriteLine("You died...sorry...");
                        //playerDeath();
                    }
                }
                else
                {
                    TextMod.CritTF();
                    Console.Write("CRITICAL HIT!! {0} hits you for {1} damage!", enemyName, enemyAP * 2);
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    playerHP -= enemyAP * 2;
                    foreach (Player p in playerList)
                    {
                        p.HealthPl = playerHP;
                        Console.WriteLine("PLAYER HEALTH: " + playerHP);
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (playerHP <= 0)
                    {
                        Console.WriteLine("You died...sorry...");
                        //playerDeath();
                    }
                }



            }

        }
    }
}
