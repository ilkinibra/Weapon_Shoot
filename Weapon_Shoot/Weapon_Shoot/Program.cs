using System;
using Weapon_Shoot.Models;

namespace Weapon_Shoot
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstInformation

            Weapon weapon = new Weapon();
            Console.WriteLine("Please Enter The Magazine Size");
        tryentercharger:
            weapon.Charger = Convert.ToInt32(Console.ReadLine());
            if (weapon.charger == 0)
            {
                Console.WriteLine("Wrong bullet count.\nPlease try again");
                goto tryentercharger;
            }
            weapon.NowCharger();
            weapon.mode = "Single";
            Console.Clear();

        #endregion

        #region Menu

        menu:
            Console.WriteLine("0.To get information\n1.Shoot Single mode\n2.Shoot FullAuto mode\n3.Get remain bullet count\n4.Reload the weapon\n5.Change Fire Mode\n6.Edit the bullet\n7.Close program");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine($"Magazine capacity: {weapon.charger}\n");
                    Console.WriteLine($"Now magazine: {weapon.nowcharger}\n");
                    Console.WriteLine($"Weapon mode: {weapon.mode}\n");
                    goto menu;
                case 1:
                    Console.Clear();
                    weapon.FireModeSingle();
                    goto menu;
                case 2:
                    Console.Clear();
                    weapon.FireModeFullAuto();
                    goto menu;
                case 3:
                    Console.Clear();
                    weapon.GetRemainBulletCount();
                    Console.WriteLine($" Get Remain Bullet Count: {weapon.remainbullet}\n");
                    goto menu;
                case 4:
                    Console.Clear();
                    weapon.Reload();
                    goto menu;
                case 5:
                    Console.Clear();
                    weapon.ChangeFireMode();
                    goto menu;
                case 6:
                    Console.Clear();
                    Console.WriteLine("T - Change magazine capacity\nQ - Change now magazine bullet count\n= - Press any button to return");
                    string menusection = Console.ReadLine();
                    string editmenu = menusection.ToUpper();
                    if (editmenu == "T")
                    {
                    tryeditcharger:
                        weapon.Charger = Convert.ToInt32(Console.ReadLine());
                        if (weapon.charger == 0)
                        {
                            Console.WriteLine("Wrong bullet count.\nPlease try again");
                            goto tryeditcharger;
                        }
                        if (weapon.nowcharger >= weapon.charger)
                        {
                            weapon.NowCharger();
                        }
                        goto menu;
                    }
                    else if (editmenu == "Q")
                    {
                        Console.Clear();
                    tryenternowcharger:
                        weapon.ChangeNowCharger = Convert.ToInt32(Console.ReadLine());
                        if (weapon.nowcharger == -1)
                        {
                            Console.WriteLine("Wrong bullet count.\nPlease try again");
                            goto tryenternowcharger;
                        }
                        goto menu;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Nothing has changed");
                        goto menu;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("===Thanks Goodbye \nProgram Exit!!!===");
                    break;
            }

            #endregion
        }
    }
}
