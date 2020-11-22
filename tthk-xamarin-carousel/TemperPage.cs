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
        private Label temperTitleLabel, temperDescriptionLabel;
        private Button temperTestButton;
        private string temperTestUrl;
        public TemperPage(Temperament _temperament)
        {
            temperament = _temperament;
            temperImage = new Image();
            temperTestButton.Clicked += TempTestButtonOnClicked;
            FlexLayout flexLayout = new FlexLayout();
        }

        private void TempTestButtonOnClicked(object sender, EventArgs e)
        {
            Browser.OpenAsync(temperament.TestURL);
        }
    }
}