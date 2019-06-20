/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 15:57
 * 
 */
using System;
using System.Windows.Input;

namespace WeaponStatGenerator.Services
{
/// <summary>
/// A command whose sole purpose is to 
/// relay its functionality to other
/// objects by invoking delegates. The
/// default return value for the CanExecute
/// method is 'true'.
/// </summary>
	public class RelayCommand : ICommand
	{
	   	private Action<object> _action;
	    public RelayCommand(Action<object> action)
	    {
	        _action = action;
	    }
	 
	    public bool CanExecute(object parameter)
	    {
	        return true;
	    }
	 
	    public void Execute(object parameter)
	    {
           _action(parameter);
        }
	 
	    public event EventHandler CanExecuteChanged;
	}
}
