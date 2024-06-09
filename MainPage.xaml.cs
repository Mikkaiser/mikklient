using Mikklient.ViewModels;

namespace Mikklient
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            BindingContext = viewModel;
        }
    }

}
