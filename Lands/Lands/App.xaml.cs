using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lands
{
    using Views;

    public partial class App : Application
    {
        #region Constructors
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            this.MainPage = new LoginPage();
        }
        #endregion

        #region Methods
        protected override void OnStart() //Una vez cuando se ejecuta
        {
            // Handle when your app starts
        }

        protected override void OnSleep() //Cuando la aplicacion se duerme 
        {
            // Handle when your app sleeps
        }

        protected override void OnResume() //Vuelvo a la aplicación despues de sleep
        {
            // Handle when your app resumes
        }
        #endregion
    }
}
