using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Gymnastic_User
{
	public partial class App : Application
	{
        public static MasterDetailPage DetailPage { get; set; }
      
        public App ()
		{
			InitializeComponent();
            MainPage = new MainPage();
		}

        public async static Task NavigateToPage(Page page)
        {
            DetailPage.IsPresented = false;
            await DetailPage.Detail.Navigation.PushAsync(page);
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
