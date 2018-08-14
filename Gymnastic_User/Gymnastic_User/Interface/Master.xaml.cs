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
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();
            var binding = new MasterDetailPage1MasterViewModel();
            BindingContext = binding;
		}
        class MasterDetailPage1MasterViewModel
        {
            public List<MasterDetailPage1MenuItem> MenuItems { get; set; }

            public MasterDetailPage1MasterViewModel()
            {
                MenuItems = new List<MasterDetailPage1MenuItem>(new[]
                {
                    new MasterDetailPage1MenuItem("Page 1" , PageType.Page1),
                    new MasterDetailPage1MenuItem ("Page 2" , PageType.Page2)
                });
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            Page page = null;
            switch (but.Text)
            {
                case "Page 1":
                    page = new Page1();
                    break;
                case "Page 2":
                    page = new Page2();
                    break;
            }
            await App.NavigateToPage(page);
        }
    }
}