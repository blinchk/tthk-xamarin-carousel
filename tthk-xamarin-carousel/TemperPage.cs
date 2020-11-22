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
        private Image tempImage;
        private Label tempTitleLabel, tempDescriptionLabel;
        private Button tempTestButton;
        private string tempTestUrl;
        public TemperPage()
        {
            tempImage = new Image();
            tempTestButton.Clicked += TempTestButtonOnClicked;
            FlexLayout flexLayout = new FlexLayout();
        }

        public string TemperTitle
        {
            get
            {
                return tempTitleLabel.Text;
            }
            set
            {
                tempTitleLabel.Text = value;
            }
        }

        public string TemperDescription
        {
            get
            {
                return tempDescriptionLabel.Text;
            }
            set
            {
                tempDescriptionLabel.Text = value;
            }
        }

        private void TempTestButtonOnClicked(object sender, EventArgs e)
        {
            Browser.OpenAsync(tempTestUrl);
        }
    }
}