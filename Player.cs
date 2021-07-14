using System;
using System.Collections.Generic;
using System.Text;

namespace TheCellarGame
{
    public class Player
    {

        private string _name;
        private int _weaponStr;
        private int _health;
        public string NamePl
        {
            get { return _name; }
            set { _name = value; }
        }
        public int WeaponStrPl
        {
            get { return _weaponStr; }
            set { _weaponStr = value; }
        }
        public int HealthPl
        {
            get { return _health; }
            set { _health = value; }
        }

        public Player()
        {
            _name = "DEFAULT";
            _weaponStr =1337;
            _health = 1337;

        }
        public Player(string NamePl, int WeaponStrPl, int HealthPl)
        {
            _name = NamePl;
            _weaponStr = WeaponStrPl;
            _health = HealthPl;
        }
    }
}
