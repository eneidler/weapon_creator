/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 13:15
 * 
 */
using System;
using System.Collections.ObjectModel;

namespace WeaponStatGenerator.Models
{
	/// <summary>
	/// Generates random names for the weapons. Broken into two parts for more variety.
	/// Uses a weapon noun that will get concatenated with a descriptor. All collections
	/// and properties are private. Names are accessed through the GetRandomWeaponNoun()
	/// and GetRandomWeaponDescriptor() methods.
	/// </summary>
	public class NameGenerator
	{
		
		ObservableCollection<string> availableWeaponNouns = new ObservableCollection<string>()
		{
			"Faith",
			"Hatred",
			"Epiphany",
			"Wish",
			"Cannon",
			"Handshake",
			"Cleaver",
            "Quake",
            "Hammer",
            "Sunder",
            "Breath"
		};
		
		string DisplayedWeaponNoun
		{
			get 
			{ 
				Random rnd = new Random();
				int index = rnd.Next(0, availableWeaponNouns.Count);
				return availableWeaponNouns[index];
			}
		}
		
		ObservableCollection<string> availableWeaponDescriptor = new ObservableCollection<string>()
		{
			"Destroying",
			"Equalizing",
			"Purifying",
			"Sanitizing",
			"Hopeful",
			"Elegant",
			"Unflinching",
            "Demolishing",
            "Shattering",
            "Imprisoning",
            "Unending",
            "Unyielding",
            "Broken"

			
		};
		
		string DisplayedWeaponDescriptor 
		{
			get 
			{ 
				Random rnd = new Random();
				int index = rnd.Next(0, availableWeaponDescriptor.Count);
				return availableWeaponDescriptor[index];
			}
		}
		
		public NameGenerator()
		{
		}
		
		public string GetRandomWeaponNoun()
		{
			return DisplayedWeaponNoun;
		}

        public string GetRandomWeaponDescriptor()
        {
            return DisplayedWeaponDescriptor;
        }
	}
}
