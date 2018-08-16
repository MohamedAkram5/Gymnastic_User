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
	public partial class Page1 : ContentPage
	{
        private readonly List<Exercise> exercises;
        public Page1()
        {
            InitializeComponent();
            exercises = new List<Exercise>()
            {
                new Exercise("ABS" , "Icon_Test.png"),
                new Exercise("Back" , "Icon_Test.png"),
            };

            foreach (var item in exercises)
            {
                StackParent.Children.Add(item);
            }
        }

        protected override void OnAppearing()
        {
            IsEnabled = true;
        }

        protected override void OnDisappearing()
        {
            IsEnabled = false;
        }
    }
}