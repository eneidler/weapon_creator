/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 09:44
 *
 */

using System;
using System.Collections.Generic;
using System.Windows.Input;
using WeaponStatGenerator.Models;
using WeaponStatGenerator.Services;

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

        private void GenerateNewWeapon(WeaponArchType weaponArchType) => GeneratedWeapon = _generateNewWeapon.Generate(weaponArchType);
    }
}