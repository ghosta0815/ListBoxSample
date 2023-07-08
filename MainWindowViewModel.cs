using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListBoxSample
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<PersonViewModel> _myCollection = new()
        {
            new PersonViewModel() {FirstName = "Dave", LastName = "O'Davidson" },
            new PersonViewModel() {FirstName = "Steve", LastName = "Rogers" }
        };

        public ObservableCollection<PersonViewModel> MyCollection
        {
            get { return _myCollection; }
            set { _myCollection = value; }
        }



        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
