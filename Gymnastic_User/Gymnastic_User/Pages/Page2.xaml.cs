﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gymnastic_User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
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