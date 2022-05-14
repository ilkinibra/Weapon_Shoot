using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon_Shoot.Models
{
    class Weapon
    {
        public int charger;
        public int nowcharger;
        public string mode;
        public int remainbullet;
        public int chg = 0;
        public Weapon() { }
        #region Charger
        public int Charger
        {
            get
            { return charger; }
            set
            {
                if (value > 0 && value < 1000)
                { charger = value; }
                else
                {
                    charger = 0;
                }
            }
        }

        #endregion

        #region Firemode
        public void ChangeFireMode()
        {
            if (this.chg % 2 == 0)
            {
                mode = "FullAuto";
                this.chg++;
            }
            else
            {
                mode = "Single";
                this.chg++;
            }
        }

        public void FireModeFullAuto()
        {
            if (this.nowcharger > 0)
            {
                if (mode == "FullAuto")
                {
                    this.nowcharger = 0;
                }
                else
                {
                    this.nowcharger = this.nowcharger - 1;
                }
            }
            else
            {
                this.nowcharger = 0;
                Console.WriteLine("\nThe weapon cannot fire.Because there were no bullets.\nPlease Reload weapon.\n");
            }
        }
        public void FireModeSingle()
        {
            if (this.nowcharger > 0)
            {
                this.nowcharger = this.nowcharger - 1;
            }
            else
            {
                this.nowcharger = 0;
                Console.WriteLine("\nThe weapon cannot fire.Because there were no bullets.\nPlease Reload weapon.\n");
            }
        }

        #endregion

        #region Nowcharger
        public int NowCharger()
        {
            this.nowcharger = this.charger;
            return nowcharger;
        }

        #endregion

        #region ChangeNowCharger
        public int ChangeNowCharger
        {
            get
            { return nowcharger; }
            set
            {
                if (value >= 0 && value <= this.charger)
                { nowcharger = value; }
                else
                {
                    nowcharger = -1;
                }
            }
        }

        #endregion

        #region Reload
        public void Reload()
        {
            if (this.nowcharger == this.charger)
            {
                Console.WriteLine("\nMagazine is Full !\n");
            }
            else
            {
                this.nowcharger = this.charger;
                Console.WriteLine("\nWeapon is reloaded.\n");
            }
        }

        #endregion

        #region GetRemainBulletCount
        public void GetRemainBulletCount()
        {
            this.remainbullet = this.charger - this.nowcharger;
        }
        #endregion
    }
}