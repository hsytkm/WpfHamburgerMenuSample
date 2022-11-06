using System.ComponentModel;
using System.Diagnostics;

namespace WpfHamburgerMenuSample;

internal sealed class HumburgerMenuViewModel : INotifyPropertyChanged
{
    public int SelectedPageIndex
    {
        get => _selectedPageIndex;
        set
        {
            if (SetProperty(ref _selectedPageIndex, value))
                Debug.WriteLine($"SelectedPage changed : {value}");
        }
    }
    int _selectedPageIndex = 2;     // Sepalater is counted too.

    public bool IsHamburgerMenuPaneOpen
    {
        get => _isHamburgerMenuPaneOpen;
        set
        {
            if (SetProperty(ref _isHamburgerMenuPaneOpen, value))
                Debug.WriteLine($"IsHamburgerMenuPaneOpen : {value}");
        }
    }
    bool _isHamburgerMenuPaneOpen = true;

    bool SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }
    public event PropertyChangedEventHandler? PropertyChanged;
}
