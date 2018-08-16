using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

public enum PageType { Page1, Page2 }
namespace Gymnastic_User
{

    public class MasterDetailPage1MenuItem : StackLayout
    {
        private Image image = new Image();
        private Label label = new Label();
       // private Button button = new Button();

        public PageType pageType;

        public MasterDetailPage1MenuItem( string text , PageType pageType)
        {
            SetImage();
            SetLabel(text);
          //  SetButton();
            this.pageType = pageType;
            Orientation = StackOrientation.Horizontal;
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Button_Clicked;
            GestureRecognizers.Add(tap);
        }

        private void SetImage()
        {
            image = new Image()
            {
                Source = "Icon_Test.png"
            };
            Children.Add(image);
        }

        private void SetLabel(string text)
        {
            label = new Label()
            {
                Text = text,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Children.Add(label);
        }

        //private void SetButton()
        //{
        //    button = new Button()
        //    {
        //        Text = "Go"
        //    };

        //    button.Clicked += Button_Clicked;
        //    Children.Add(button);
        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Page page = null;
            switch (pageType)
            {
                case PageType.Page1:
                    if (!AppManager.Instance.page1.IsEnabled)
                    {
                        page = AppManager.Instance.page1;
                    }
                    break;
                case PageType.Page2:
                    if (!AppManager.Instance.page2.IsEnabled)
                    {
                        page = AppManager.Instance.page2;
                    }
                    break;
            }
            if (page != null)
                await App.NavigateToPage(page);
            MainPage.IsPresentedAction(false);
        }
    }
}