using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Gymnastic_User
{
    class Exercise : StackLayout
    {
        private Image image;
        private Label label1;
        private Label label2;

        public Exercise(string text , string imageSource)
        {
            Orientation = StackOrientation.Horizontal;
            SetImage(imageSource);
            SetLabels(text);
        }

        private void SetImage(string source)
        {
            image = new Image()
            {
                Source = source
            };
            Children.Add(image);
        }

        private void SetLabels(string text)
        {
            label1 = new Label()
            {
                Text = text,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            label2 = new Label()
            {
                Text = ">    ",
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
            };

            Children.Add(label1);
            Children.Add(label2);
        }
    }
}
