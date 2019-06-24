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
	/// This class is used for generating the damage stat in the application.
	/// It creates a random value between 50 and 200, which can then be used
	/// in the view through bindings when the generate button is clicked.
	/// </summary>
	public class DamageStatGenerator
	{
		
		const int maxDamageValue = 200;
		const int minDamageValue = 50;
		
		public DamageStatGenerator()
		{
		}
		
		public int GetRandomDamageValue()
		{
			Random random = new Random();
			int randomDamageValue = random.Next(minDamageValue, maxDamageValue);
			return randomDamageValue;
		}
		
	}
}
