using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SlicerProto.Options
{
    public abstract class BaseOptions : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
