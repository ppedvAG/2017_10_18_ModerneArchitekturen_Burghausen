
using Lobster.ViewModels;
using Xamarin.Forms;

namespace Lobster.Views
{
    public partial class MainPage : ContentPage
    {
        protected MainViewModel ViewModel { get; }

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = ViewModel = viewModel;
        }

        protected override async void OnAppearing() => await ViewModel.Initialize();
    }
}