using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

//TS TOOL
/*foreach (var player in playerList)

{
    Console.WriteLine("\nPLAYER NAME:{0} ATTACK STRENGTH:{1} HEALTH:{2}", player.NamePl, player.WeaponStrPl, player.HealthPl);
}
Console.ReadKey();*/

namespace TheCellarGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Player> PlayerList = new List<Player>();
            List<Enemy> EnemyList = new List<Enemy>();
            int areaCounter = 0;



            Banner.BannerF();
                           
            Console.ReadKey();

            Console.Write("What is your name?\n>");
            string playerName = Console.ReadLine();
            PlayerList.Add(new Player(playerName, 1, 20));


            foreach (var player in PlayerList)
            {
                TextMod.StaTF();
                Console.WriteLine("\nPLAYER NAME:{0} ATTACK STRENGTH:{1} HEALTH:{2}", player.NamePl, player.WeaponStrPl, player.HealthPl);
                Console.ResetColor();
            }



            Console.ReadLine();

            Area1.Area1Func(PlayerList, EnemyList, areaCounter);
            Area2.Area2Func(PlayerList, EnemyList, areaCounter);
            //Area1.Area1Func(PlayerList, EnemyList, areaCounter);
            //Area1.Area1Func(PlayerList, EnemyList, areaCounter);
            //Area1.Area1Func(PlayerList, EnemyList, areaCounter);



        }

    }
}





