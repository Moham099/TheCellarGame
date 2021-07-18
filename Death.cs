using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCellarGame
{
    public class Death
    {
        public static void PlayerDeath()
        {
            TextMod.CritTF();
            Console.Write("################\n    YOU DIED    \n################");
            Console.ResetColor();
           

            Console.WriteLine("\n\nPress Enter to EXIT");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
