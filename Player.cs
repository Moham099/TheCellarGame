using System;
using System.Collections.Generic;
using System.Text;

namespace TheCellarGame
{
    public class Player : Character
    {

        //public string _name;
        //public string _weaponName;
        //public int _weaponStr;
        //public int _health;

        //public string Name { get; set; }
        //public string WeaponName { get; set; }
        //public int WeaponStr { get; set; }
        //public int Health { get; set; }

        //public Player()
        //{
        //    _name = "DEFAULT";
        //    _weaponName = "DEFAULT";
        //    _weaponStr = 0;
        //    _health = 0;
        //}

        public Player(string Name, string WeaponName, int WeaponStr, int Health)
        {
            _name = Name;
            _weaponName = WeaponName;
            _weaponStr = WeaponStr;
            _health = Health;
        }



    }
}
