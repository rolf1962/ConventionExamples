using System.Runtime.CompilerServices;

namespace ConventionExamples.Model
{
    public class ModelBase : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.
                PropertyChangedEventArgs(propertyName));
        }
    }
}
