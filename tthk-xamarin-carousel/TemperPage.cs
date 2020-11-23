using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
	public class TemperPage : ContentPage
    {
        private Temperament temperament;
        private Image temperImage;
        private Label temperDescriptionLabel;
        private Button temperTestButton;
        private const string temperTestUrl = "https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/";
        public TemperPage(Temperament _temperament)
        {
            temperament = _temperament;
            Title = temperament.Title;
            temperDescriptionLabel = new Label()
            {
                Text = temperament.Description
            };
            temperImage = new Image()
            {
                Source = temperament.Picture
            };
            temperTestButton.Clicked += TempTestButtonOnClicked;
            FlexLayout flexLayout = new FlexLayout()
            {
                Direction = FlexDirection.Column,
                JustifyContent = FlexJustify.SpaceEvenly,
                Children = { temperImage, temperDescriptionLabel, temperTestButton } 
            };
            Content = flexLayout;
        }

        private void TempTestButtonOnClicked(object sender, EventArgs e)
        {
            Browser.OpenAsync(temperTestUrl);
        }
    }
}