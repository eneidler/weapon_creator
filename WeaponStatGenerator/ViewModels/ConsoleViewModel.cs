/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:44
 *
 */

using System;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."
using System.Collections.Generic;
using System.Windows.Input;
=======
using System.Windows;
using System.Collections.ObjectModel;
using WeaponStatGenerator.Services;
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
using WeaponStatGenerator.Models;
<<<<<<< HEAD
=======
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."
using WeaponStatGenerator.Services;

namespace WeaponStatGenerator.ViewModels
{
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."
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
<<<<<<< HEAD
=======
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
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."
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

<<<<<<< HEAD
		
		
		
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
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
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."

        private void GenerateNewWeapon(WeaponArchType weaponArchType) => GeneratedWeapon = _generateNewWeapon.Generate(weaponArchType);
    }
=======
<<<<<<< HEAD
=======
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."
		
		
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
	}
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
=======
=======
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
	
		
	#region INotifyPropertyChanged Implementation Boilerplate
	    //Property change event handler
	    /// <summary>
	    /// This property change event handler will be used to tie in PropertyChanged notifications
	    /// for use in View to ViewModel databinding.
	    /// </summary>
	    public event PropertyChangedEventHandler PropertyChanged;
	    private void OnPropertyChanged(string name)
	    {
	        PropertyChangedEventHandler handler = PropertyChanged;
	        if (handler != null)
	            handler(this, new PropertyChangedEventArgs(name));
	    }
	#endregion
	}
<<<<<<< HEAD
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
	}
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
>>>>>>> parent of 014d046... Revert "Resolved merge conflict by using the refactor files and code."
}
