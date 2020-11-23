using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
    class TemperLoader
    {
        public static List<Temperament> LoadFromXml()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("Temperaments.xml"));
            XDocument doc = XDocument.Load(resourceName);
            IEnumerable<Temperament> tempers = from temperament in doc.Descendants("temperament")
                select new Temperament()
                {
                    Title = temperament.Attribute("title").Value,
                    Description = temperament.Attribute("description").Value,
                    Picture = ImageSource.FromFile(temperament.Attribute("picture").Value)
                };
            return tempers.ToList();
        }
    }
}
