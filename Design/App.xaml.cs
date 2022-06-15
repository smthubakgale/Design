using Design.Views.Shared; 
using Xamarin.Forms;

namespace Design
{
    public partial class App : Application
	{ 
		// Constructor
		public App()
		{
			InitializeComponent(); 

			MainPage = new _Layout() ; 
		}
        // Methods 

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
		//
	}
}
