using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCellarGame
{
    public class Banner
    {
        public static void BannerF()
        {
            TextMod.BanTF();
            Console.WriteLine("#####  #   #  #####       #####  #####  #      #      #####  #####");
            Console.WriteLine("  #    #   #  #           #      #      #      #      #   #  #   #");
            Console.WriteLine("  #    #####  #####       #      #####  #      #      #####  #####");
            Console.WriteLine("  #    #   #  #           #      #      #      #      #   #  # #  ");
            Console.WriteLine("  #    #   #  #####       #####  #####  #####  #####  #   #  #   #");
            Console.ResetColor();
        }
    }
}
