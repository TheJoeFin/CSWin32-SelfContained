using System.Windows;
using Windows.Win32.Foundation;
using static Windows.Win32.PInvoke;

namespace CSWinRT_SelfContained;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        HWND shellWindow = GetShellWindow();
        double dpi = 96.0 / GetDpiForWindow(shellWindow);
        DpiTextblock.Text = $"{dpi} scale factor";
    }
}