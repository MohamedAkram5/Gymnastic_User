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
        private readonly List<MasterDetailPage1MenuItem> itemsList = new List<MasterDetailPage1MenuItem>();

        public Master()
        {
            InitializeComponent();
            itemsList.Add(new MasterDetailPage1MenuItem("Page 1" , PageType.Page1));
            itemsList.Add(new MasterDetailPage1MenuItem("Page 2" , PageType.Page2));

            ParentStack.Children.Add(itemsList[0]);
            ParentStack.Children.Add(itemsList[1]);
        }
    }
}