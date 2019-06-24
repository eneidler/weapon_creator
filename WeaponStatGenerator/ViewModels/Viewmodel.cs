using System.ComponentModel;

namespace WeaponStatGenerator.ViewModels
{
    public abstract class Viewmodel : INotifyPropertyChanged
    {
        //Property change event handler
        /// <summary>
        /// This property change event handler will be used to tie in PropertyChanged notifications
        /// for use in View to ViewModel databinding.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyOnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}