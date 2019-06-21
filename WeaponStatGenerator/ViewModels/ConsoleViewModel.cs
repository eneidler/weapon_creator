/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:44
 * 
 */
using System;
using System.Windows;
using System.Collections.ObjectModel;
using WeaponStatGenerator.Services;
using WeaponStatGenerator.Models;

namespace WeaponStatGenerator.ViewModels
{
	/// <summary>
	/// ConsoleViewModel is the main viewModel for application. It holds the properties that are bound
	/// to the view (Console.xaml), as well as containing the logic for the new weapon generator button.
	/// </summary>
	public class ConsoleViewModel : BaseViewModel
	{
		
		NameGenerator nameGenerator = new NameGenerator();
		DamageTypeGenerator damageType = new DamageTypeGenerator();
		DamageStatGenerator damageStat = new DamageStatGenerator();
		Weapon weapon = new Weapon();
		
		
		//This Observable collection uses the enum values from the Weapon class to populate it with string values of the weapon types.
		ObservableCollection<string> weaponArchTypes = new ObservableCollection<string>(Enum.GetNames(typeof(Weapon.WeaponArchType)));
		public ObservableCollection<string> WeaponArchTypes 
		{
			get 
			{ 
				return weaponArchTypes;
			}
			set 
			{ 
				weaponArchTypes = value;
				OnPropertyChanged("WeaponArchType");
				OnPropertyChanged("SelectedWeaponArchType");
			}
		}
		
		string selectedWeaponArchType;
		public string SelectedWeaponArchType 
		{
			get 
			{ 
				return selectedWeaponArchType; 
			}
			set 
			{ 
				selectedWeaponArchType = value;
				OnPropertyChanged("SelectedWeaponArchType");
				OnPropertyChanged("WeaponArchType");
				OnPropertyChanged("GenerateWeaponCommand");
			}
		}
		
		string selectedWeaponIcon;	
		public string SelectedWeaponIcon 
		{
			get 
			{ 
				selectedWeaponIcon = weapon.GetWeaponIcon(SelectedWeaponArchType);
				return selectedWeaponIcon;
			}
			set 
			{ 
				selectedWeaponIcon = value;
				OnPropertyChanged("SelectedWeaponIcon");
				OnPropertyChanged("GenerateWeaponCommand");
				
			}
		}
		
		string generatedWeaponName;		
		public string GeneratedWeaponName 
		{
			get 
			{ 
				generatedWeaponName = nameGenerator.GetRandomWeaponDescriptor() + " " + nameGenerator.GetRandomWeaponNoun();
				return generatedWeaponName;
			}
			set 
			{ 
				generatedWeaponName = value;
				OnPropertyChanged("GeneratedWeaponName");
			}
		}
		
		string generatedDamageType;
		public string GeneratedDamageType 
		{
			get 
			{ 
				generatedDamageType = damageType.GetRandomDamageType();
				return generatedDamageType;
			}
			set 
			{ 
				generatedDamageType = value;
				OnPropertyChanged("GeneratedDamageType");
			}
		}
		
		int generatedDamageStat;
		public int GeneratedDamageStat 
		{
			get 
			{ 
				generatedDamageStat = damageStat.GetRandomDamageValue();
				return generatedDamageStat;
			}
			set 
			{ 
				generatedDamageStat = value; 
				OnPropertyChanged("GeneratedDamageStat");
			}
		}
		
        private RelayCommand generateWeaponCommand;       
        public RelayCommand GenerateWeaponCommand
        {
            get
            {
            	if(SelectedWeaponArchType != null)
            	{
            		GenerateWeaponCommand = new RelayCommand(new Action<object>(GenerateNewWeapon));
                	return generateWeaponCommand;
            	}
            	else
            		GenerateWeaponCommand = new RelayCommand(new Action<object>(SelectWeaponErrorMessage));
            		return generateWeaponCommand;
            }            	
            set
            {
                generateWeaponCommand = value;
            }
        }

		
		public ConsoleViewModel()
		{
		}
		
		
		/// <summary>
		/// The GenerateNewWeapon() method is used for creating a new on button press.
		/// It is used in conjuction with the RelayCommand GenerateWeaponCommand, which 
		/// is then bound to the "Command" property of the Console.xaml file.
		/// </summary>
		/// <param name="obj"></param>
		private void GenerateNewWeapon(object obj)
		{
			GeneratedWeaponName = nameGenerator.GetRandomWeaponDescriptor() + " " + nameGenerator.GetRandomWeaponNoun();
			GeneratedDamageType = damageType.GetRandomDamageType();
			GeneratedDamageStat = damageStat.GetRandomDamageValue();
			SelectedWeaponIcon = weapon.GetWeaponIcon(SelectedWeaponArchType);
        }
		
		
		/// <summary>
		/// This method is triggered in the event a weapon arch type was not selected from
		/// the list prior to hitting the generate button. Called as part of an if-else
		/// statement in the getter of GenerateWeaponCommand.
		/// </summary>
		/// <param name="obj"></param>
		private void SelectWeaponErrorMessage(object obj)
		{
			MessageBox.Show("Please select a weapon type from the list box");
		}
	}
}
