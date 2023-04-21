using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace cop4870_maui_radiostylebutton_example.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private string _displayText;

    public event PropertyChangedEventHandler PropertyChanged;

    public string DisplayText
    {
        get
        { 
            return _displayText;
        }

        set
        {
            _displayText = $"{value} Selected";
            NotifyPropertyChanged();
        }
    }
    
    public MainViewModel()
    {
        
    }

    private void NotifyPropertyChanged([CallerMemberName] string name="")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}