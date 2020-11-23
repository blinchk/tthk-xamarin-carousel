using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
	public class MainPage : CarouselPage
    {
        public MainPage()
        {
            List<Temperament> temperaments = TemperLoader.LoadFromXml();
            foreach (var temperament in temperaments)
            {
                var temperamentPage = new TemperPage(temperament);
                this.Children.Add(temperamentPage);
            }
        }
    }
}