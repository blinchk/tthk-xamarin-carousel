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
        static string[] temperamentTitles = new string[] { "Флегматик", "Холерик", "Сангвиник", "Меланхолик" };
        static string[] temperamentDescriptions = new string[]
        {
            "Спокойный, сдержанный. Он плохо приспосабливается к новой обстановке и в неблагоприятных условиях может стать пассивным и вялым, при этом отличается самообладанием, терпеливостью, предприимчивостью. В обществе флегматик в меру общителен, не любит пустословия и не подвержен панике в стрессовых ситуациях.",
            "Горячий, несдержанный, смелый, задорный. Такие люди инициативны, с азартом берутся за любую работу (кроме рутинной) и с легкостью преодолевают трудности. Они способны схватывать информацию на лету, обладают лидерскими качествами, однако нетерпеливы, вспыльчивы и подвержены эмоциональным срывам.",
            "Уравновешенный, оптимистичный, жизнерадостный. Сангвинический темперамент характеризует человека веселого, эмоционального, общительного, живущего настроением. Он легко переживает неудачи, создает приятный микроклимат в любом коллективе, но не всегда выполняет свои обещания, порой слишком поспешен в делах и суждениях и излишне самоуверен.",
            "Чувствительный, неэнергичный, болезненно реагирующий на неприятности, склонный к унынию. Люди с меланхолическим темпераментом подвержены пессимизму, излишне подозрительны и ревнивы, но обладают аналитическим мышлением, творчески подходят к работе, тонко чувствуют и доводят дело до завершения."
        };
        static string[] temperamentPictures = new string[] { "fleg.jpg", "chol.jpg", "sangv.jpg", "melanch.jpg" };

        public static List<Temperament> LoadStaticValues()
        {
            List<Temperament> tempers = new List<Temperament>();
            for (int i = 0; i < temperamentTitles.Length; i++)
            {
                tempers.Add(new Temperament()
                {
                    Title = temperamentTitles[i],
                    Description = temperamentDescriptions[i],
                    Picture = temperamentPictures[i]
                });
            }
            return tempers.ToList();
        }
    }
}
