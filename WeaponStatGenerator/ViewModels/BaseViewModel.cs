/*
 * User: eneidler
 * Date: 6/20/2019
 * Time: 3:27 PM
 * 
 */
using System;
using System.ComponentModel;

namespace WeaponStatGenerator.ViewModels
{
	/// <summary>
	/// Description of BaseViewModel.
	/// </summary>
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}
		
		#region INotifyPropertyChanged Implementation Boilerplate
	    //Property change event handler
	    /// <summary>
	    /// This property change event handler will be used to tie in PropertyChanged notifications
	    /// for use in View to ViewModel databinding.
	    /// </summary>
	    public event PropertyChangedEventHandler PropertyChanged;
	    protected void OnPropertyChanged(string name) //use nameof(Property) once in VisualStudio. SharpDevelop stops at C# 5.0
	    {
	        PropertyChangedEventHandler handler = PropertyChanged;
	        if (handler != null)
	            handler(this, new PropertyChangedEventArgs(name));
	    }
	#endregion
	}
}

