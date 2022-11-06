using System.Diagnostics;
using System.Windows.Controls;

namespace WpfHamburgerMenuSample;

public partial class BlankPage : UserControl
{
    public Guid Guid { get; } = Guid.NewGuid();

    public BlankPage()
    {
        InitializeComponent();
        Debug.WriteLine($"Create BlankPage.xaml -> {Guid}");
    }
}
