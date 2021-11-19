using System;
using BTTH5.DatabaseManager;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Create DB
            Database db = new Database();
            db.CreateDatabase();
            //db.DropDatabase();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
