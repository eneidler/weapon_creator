/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:44
 *
 */

using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Windows.Input;
=======
using System.Windows;
using System.Collections.ObjectModel;
using WeaponStatGenerator.Services;
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
using WeaponStatGenerator.Models;
using WeaponStatGenerator.Services;

namespace WeaponStatGenerator.ViewModels
{
<<<<<<< HEAD
    /// <summary>
    /// ConsoleViewModel is the main viewModel for application. It holds the properties that are bound
    /// to the view (Console.xaml), as well as containing the logic for the new weapon generator button.
    /// </summary>
    public class ConsoleViewModel : Viewmodel
    {
        private readonly IGenerateNewWeapon _generateNewWeapon;
        private IList<WeaponArchType> _weaponArchTypes = ((WeaponArchType[])Enum.GetValues(typeof(WeaponArchType)));

        // NOTE: Class fields should be preceeded with an underscore so you don't have to continuously navigate up here to check if it's
        // a local variable or a field.
        private WeaponArchType? _selectedWeaponArchType;

        private ICommand _generateWeaponCommand;
        private Weapon generatedWeapon;

        public ConsoleViewModel(IGenerateNewWeapon generateNewWeapon)
=======
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
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
        {
            _generateNewWeapon = generateNewWeapon;
        }

        public IList<WeaponArchType> WeaponArchTypes
        {
            get => _weaponArchTypes;
            set
            {
                _weaponArchTypes = value;
                NotifyOnPropertyChanged(nameof(SelectedWeaponArchType));
                NotifyOnPropertyChanged(nameof(WeaponArchTypes));
            }
        }

        public WeaponArchType? SelectedWeaponArchType
        {
            get => _selectedWeaponArchType;
            set
            {
                _selectedWeaponArchType = value;
                NotifyOnPropertyChanged(nameof(SelectedWeaponArchType));
            }
        }

        //This is a short version of saying "if null, generate and assign new relay command"
        //If the command is clicked a second time, it will reuse the created command.
        public ICommand GenerateWeaponCommand { get => _generateWeaponCommand ?? (_generateWeaponCommand = new RelayCommand<object>(_ => GenerateNewWeapon(SelectedWeaponArchType.Value), _ => SelectedWeaponArchType != null)); }

        public Weapon GeneratedWeapon
        {
            get => generatedWeapon;
            set
            {
                generatedWeapon = value;
                NotifyOnPropertyChanged(nameof(GeneratedWeapon));
            }
        }
<<<<<<< HEAD

        private void GenerateNewWeapon(WeaponArchType weaponArchType) => GeneratedWeapon = _generateNewWeapon.Generate(weaponArchType);
    }
=======
		
		
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
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
}
