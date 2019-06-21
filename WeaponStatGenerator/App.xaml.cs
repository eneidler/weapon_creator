using System.Windows;
using WeaponStatGenerator.Models;
using WeaponStatGenerator.ViewModels;

namespace WeaponStatGenerator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var viewmodel = new ConsoleViewModel(
                new GenerateNewWeapon(
                    new GenerateWeaponName(),
                    new GenerateDamageType(),
                    new GenerateDamageStat()));

            new Console() { DataContext = viewmodel }.ShowDialog();
        }
    }
}