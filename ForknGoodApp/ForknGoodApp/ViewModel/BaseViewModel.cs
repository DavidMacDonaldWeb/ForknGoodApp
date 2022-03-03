using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ForknGoodApp.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged  //Used to notify the system of item selected and draws the details page to be diplayed of that selected recipe
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

//David MacDonald
