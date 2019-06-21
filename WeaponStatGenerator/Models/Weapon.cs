/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:29
 * 
 */
using System;

namespace WeaponStatGenerator.Models
{
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
			switch (selectedWeapon) 
			{
				case "Pistol":
					selectedWeapon = "/images/pistol.ico";
					break;
				case "Shotgun":
					selectedWeapon = "/images/shotgun.ico";
					break;	
				case "Carbine":
					selectedWeapon = "/images/carbine.ico";
					break;
				case "Rifle":
					selectedWeapon = "/images/rifle.ico";
					break;
				case "Sniper":
					selectedWeapon = "/images/sniper.ico";
					break;
				case null:
					selectedWeapon = "/images/refresh.ico";
					break;
			}
			return selectedWeapon;
		}
		
	}
}
