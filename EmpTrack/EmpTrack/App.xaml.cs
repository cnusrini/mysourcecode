using Xamarin.Forms;

namespace EmpTrack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Views.Login.LoginPage();
           // MainPage = new NavigationPage(new Views.Login.LoginPage());
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
