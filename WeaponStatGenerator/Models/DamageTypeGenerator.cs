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
	/// This class generates a random damage type that can be used 
	/// with the button press to generate new weapon damage types.
	/// </summary>
	public class DamageTypeGenerator
	{
		
		ObservableCollection<string> availableDamageTypes = new ObservableCollection<string>()
		{
			"Lightning",
			"Fire",
			"Ice",
			"Solar",
			"Shadow",
			"Poison",
			"Kinetic"
		};
		
		string DisplayedDamageType
		{
			get
			{
				Random rnd = new Random();
				int index = rnd.Next(0, availableDamageTypes.Count);
				return availableDamageTypes[index];	
			}
		}
		
		public DamageTypeGenerator()
		{
		}
		
		public string GetRandomDamageType()
		{
			return DisplayedDamageType;
		}
	}
}
