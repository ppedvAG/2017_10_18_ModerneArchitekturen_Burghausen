
using Xamarin.Forms;

namespace Lobster
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var crabService = new Services.CrabService();
            var mainViewModel = new ViewModels.MainViewModel(crabService);
            MainPage = new Views.MainPage(mainViewModel);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
