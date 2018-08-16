using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gymnastic_User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
        public static Action<bool> IsPresentedAction;
        public MainPage()
        {
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail()) { BarBackgroundColor = Color.Black, BarTextColor = Color.White };
            App.DetailPage = this;
            IsPresentedAction = (a) =>
            {
                IsPresented = a;
            };
        }
    }
}