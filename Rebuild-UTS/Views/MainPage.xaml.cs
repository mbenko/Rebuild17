using Rebuild_UTS.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Rebuild_UTS.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
