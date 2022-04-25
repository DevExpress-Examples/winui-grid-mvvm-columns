using Microsoft.UI.Xaml.Controls;

namespace GridMVVMColumns {
    public sealed partial class MainPage : Page {
        public ViewModel ViewModel { get; } = new ViewModel();
        public MainPage() {
            this.InitializeComponent();
        }
    }
}
