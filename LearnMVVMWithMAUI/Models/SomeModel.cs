using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LearnMVVMWithMAUI.Models
{
    public class SomeModel : INotifyPropertyChanged
    {
        private string _someString;
        public event PropertyChangedEventHandler PropertyChanged;

        public string SomeString
        {
            get => _someString;
            set
            {
                if (_someString == value)
                    return;
                _someString = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
