﻿/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:29
 *
 */

namespace WeaponStatGenerator.Models
{
<<<<<<< HEAD
    /// <summary>
    /// The weapon class is used for giving a framework for the types of weapons,
    /// and a way to access their icons.
    /// </summary>
    public class Weapon
    {
        public Weapon(
            string name,
            WeaponArchType weaponType,
            int damageStat,
            DamageType damageType)
        {
            Name = name;
            WeaponType = weaponType;
            Damage = damageStat;
            DamageType = damageType;
        }

        public string Name { get; }
        public WeaponArchType WeaponType { get; }
        public int Damage { get; }
        public DamageType DamageType { get; }

        public string Icon => GetIcon(WeaponType);

        /// <summary>
        /// This method is used to provide an abstracted way to deliver the image strings for
        /// the weapon icons, so they can be easily bound in the ConsoleViewModel.
        /// </summary>
        /// <param name="selectedWeapon"></param>
        /// <returns>selectedWeapon</returns>
        private string GetIcon(WeaponArchType weaponType)
        {
            switch (weaponType)
            {
                case WeaponArchType.Pistol:
                    return "/images/pistol.ico";

                case WeaponArchType.Shotgun:
                    return "/images/shotgun.ico";

                case WeaponArchType.Carbine:
                    return "/images/carbine.ico";

                case WeaponArchType.Rifle:
                    return "/images/rifle.ico";

                case WeaponArchType.Sniper:
                    return "/images/sniper.ico";

                default:
                    return "/images/refresh.ico";
            }
        }
    }
=======
	/// <summary>
	/// The weapon class is used for giving a framework for the types of weapons,
	/// and a way to access their icons.
	/// </summary>
	public class Weapon
	{
		
		public enum WeaponArchType
		{
			Pistol,
			Shotgun,
			Carbine,
			Rifle,
			Sniper
		}
		
		public Weapon()
		{
		}
		
		
		/// <summary>
		/// This method is used to provide an abstracted way to deliver the image strings for 
		/// the weapon icons, so they can be easily bound in the ConsoleViewModel.
		/// </summary>
		/// <param name="selectedWeapon"></param>
		/// <returns>selectedWeapon</returns>
		public string GetWeaponIcon(string selectedWeapon)
		{
			if(!string.IsNullOrEmpty(selectedWeapon))
			{
				switch (selectedWeapon.ToLower())
				{
					case "pistol":
						selectedWeapon = "/images/pistol.ico";
						break;
					case "shotgun":
						selectedWeapon = "/images/shotgun.ico";
						break;	
					case "carbine":
						selectedWeapon = "/images/carbine.ico";
						break;
					case "rifle":
						selectedWeapon = "/images/rifle.ico";
						break;
					case "sniper":
						selectedWeapon = "/images/sniper.ico";
						break;
					default:
						selectedWeapon = "/images/refresh.ico";
						break;
				}
			}
			else
			{
				selectedWeapon = "/images/refresh.ico";
			}
			return selectedWeapon;
		}
		
	}
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
}

