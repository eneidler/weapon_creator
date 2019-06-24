/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:44
 * 
 */
using System;
using System.Collections.Generic;
using System.Windows.Input;
=======
using System.Windows;
using System.Collections.ObjectModel;
using WeaponStatGenerator.Services;
>>>>>>> cfaac5aab127d08f9cfc654cf44db5101a806ee4
using WeaponStatGenerator.Models;
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
using WeaponStatGenerator.Services;
using WeaponStatGenerator.Models;

namespace WeaponStatGenerator.ViewModels
{

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

        private void GenerateNewWeapon(WeaponArchType weaponArchType) => GeneratedWeapon = _generateNewWeapon.Generate(weaponArchType);
    }
=======
=======
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
=======
>>>>>>> parent of e9ec55b... Resolved merge conflict by using the refactor files and code.
		
		
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
}
