using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCellarGame

{
    public class Character
    {
        protected string _name;
        protected string _weaponName;
        protected int _weaponStr;
        protected int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
            

        public string WeaponName
        {
            get { return _weaponName; }
            set { _weaponName = value; }
        }
        public int WeaponStr
        {
            get { return _weaponStr; }
            set { _weaponStr = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public Character()
        {
            _name = "";
            _weaponName = "";
            _weaponStr = 0;
            _health = 0;
        }

        public Character(string Name, string WeaponName, int WeaponStr, int Health)
        {
            _name = Name;
            _weaponName = WeaponName;
            _weaponStr = WeaponStr;
            _health = Health;
        }
    }
}
