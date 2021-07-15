using System;
using System.Collections.Generic;
using System.Text;

namespace TheCellarGame
{
    public class Enemy
    {

        private string _name;
        private string _weaponName;
        private int _weaponStr;
        private int _health;

        public string NameEn
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string WeaponNameEn
        {
            get { return this._weaponName; }
            set { this._weaponName = value; }
        }
        public int WeaponStrEn
        {
            get { return this._weaponStr; }
            set { this._weaponStr = value; }
        }
        public int HealthEn
        {
            get { return this._health; }
            set { this._health= value; }
        }


        public Enemy()
        {
           
            _name = enemyName();
            _weaponName = weaponName();
            _weaponStr = weaponStr(_weaponName);
            _health = enemyHealth();
        }
   
        static string enemyName()
        {

            Random name = new Random();

            switch (name.Next(1, 4))
            {
                case 1:
                    return "RAT";
                case 2:
                    return "GOBLIN";
                case 3:
                    return "GNOME";
                default:
                    return "RAT";
            }

        }
        static string weaponName()
        {
            Random name = new Random();

            switch (name.Next(1, 5))
            {
                case 1:
                    return "DAGGER";
                case 2:
                    return "SHORT SWORD";
                case 3:
                    return "SPOON";
                case 4:
                    return "NOTHING";
                default:
                    return "NOTHING";
            }
        }

        static int weaponStr(string weaponName)
        {
            string weapon = weaponName;

            switch (weapon)
            {
                case "DAGGER":
                    return 3;
                case "SHORT SWORD":
                    return 4;
                case "SPOON":
                    return 2;
                case "NOTHING":
                    return 1;
                default:
                    return 2;

            }
        }
        static int enemyHealth()
        {
            Random HP = new Random();

            switch (HP.Next(1, 4))
            {
                case 1:
                    return 10;
                case 2:
                    return 15;
                case 3:
                    return 17;
                default:
                    return 12;
            }
        }

    }
}
