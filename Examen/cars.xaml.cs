using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen
{
   public partial class cars : ContentPage
    {
        public cars()
        {
            InitializeComponent();

            List<images> i = new List<images>()
            {
                new images(){Title="Mercedes-AMG G 63",Url="https://www.mercedes-benz.fr/passengercars/mercedes-benz-cars/models/g-class/suv-w463/amg/exterior-design/_jcr_content/par/doubleimagecombinati/par/doubleimageelement/asset.MQ6.12.20191203164311.jpeg",Text="Track-proven AMG drivetrain and chassis technologies onboard the off-roader.  The combination of the unparalleled strength of the twin-turbo V8 and its running gear opens up the field of possibiliti But also with an AMG design that will leave no one indifferent." },
                new images(){Title="Classe C Berline",Url="https://www.sayarti.tn/wp-content/uploads/2021/12/mercedes-benz-classe-c-180-prix-maison-tunisie.jpg",Text="Découvrez tout ce qu'il faut savoir sur la consommation, le moteur, la puissance, le volume du coffre, les dimensions et autres caractéristiques techniques de la Classe C Berline." },
                new images(){Title="Porshe Cayenne",Url="https://files.porsche.com/filestore/image/multimedia/none/cayenne-models-e3chili-announcement/preview/1cc14607-c9ea-11eb-80d7-005056bbdc38;sJ;twebp/porsche-preview.webp",Text="Le Cayenne et le Cayenne Coupé : les deux modèles impressionnent par leur silhouette unique et leurs performances. Avec jusqu'à 5 sièges, c’est à vous de voir si vous préférez partir seul ou avec des amis pour votre prochaine aventure en Cayenne ou si vous craquez pour les lignes emblématiques du Coupé." },
                new images(){Title="La 911 Turbo",Url="https://pics.porsche.com/rtt/iris?COSY-EU-100-1713c6eK12UC31P3T5JOCU%25hjdmiTDDmvMXlHWguCuq6Q44RtRHo9ZAaDjau5PwI7tGW3rNbZJNKXv9Z7KcQQ%25yFN5tFAsXrw4r3wo0qnqZr8MCnR4i84tV2YN2OmNyW1QGWgCWKMUuyO9I7KMIHWhQ5rEpNFrgYKyXrIpQ9%25xqrfIjO9bDrxDN9zOFPpI7sXHerhM0iWuZSR1D69sT9Oy4qDAslJAwd0zM5Q%25H7JFmYO0jOq27AaD8wZoheAg1MbeSX24D",Text="Nos ingénieurs aiment en parler comme de la voiture de sport la plus aboutie de toutes. Extrêmement sportive, tout en étant confortable et parfaitement utilisable au quotidien. Les modèles 911 Turbo continuent eux aussi de progresser dans cette voie." },
                new images(){Title="BMW XM",Url="https://www.bmw-tunisia.com/content/dam/bmw/common/all-models/m-series/xm/2022/Highlights/bmw-x-series-xm-phev-mc-electric-driving-hero-desktop.jpg/jcr:content/renditions/cq5dam.resized.img.1680.large.time1662478387865.jpg",Text="Exclusive, expressive, électrifiée : la Nouvelle BMW XM combine une présence impressionnante avec les hautes performances d'une BMW M et une technologie Hybride Rechargeable puissante de dernière génération." },
                new images(){Title="BMW i7",Url="https://www.bmw.fr/content/bmw/marketFR/bmw_fr/fr_FR/all-models/bmw-i/i7/2022/bmw-i7-series-sedan-highlights/jcr:content/par/multicontent_885774560/tabs/multicontenttab/items/smallteaser_1254337035/image.transform/smallteaser/image.1649928056727.jpg",Text="La première limousine 100% électrique BMW i7 associe performances électriques et infodivertissement multisensoriel pour une expérience de conduite inoubliable." },
                new images(){Title="Tesla Model X",Url="https://tesla-cdn.thron.com/delivery/public/image/tesla/8410774a-2d2c-4867-805d-9a549b9eac30/bvlatuR/std/4096x2561/Model-X-Range-Hero-Desktop-LHD",Text="With up to 348 miles of estimated range and access to the world’s largest and most powerful fast charging network, you’ll spend less time plugged in and more time on the road. Chat with a Tesla Advisor to learn more about Model X or schedule a demo drive today." },
                new images(){Title="Tesla Model 3",Url="https://tesla-cdn.thron.com/delivery/public/image/tesla/b314365b-e41d-4682-b890-608bdbdfa49e/bvlatuR/std/2560x2204/Model-3-Range-Hero-Desktop-LHD",Text="Model 3 is fully electric, so you never need to visit a gas station again. If you charge overnight at home, you can wake up to a full battery every morning. And when you’re on the road, it’s easy to plug in along the way—at any public station or with the Tesla charging network." },
                new images(){Title="Audi A3",Url="https://www.audi.fr/content/dam/nemo/fr/Gamme/A3/Refonte-2022/A3SB/1920x1080_A3SB_phare_17102022-compressed.jpg?imwidth=1920&imdensity=1",Text="Avec des passages de roues expressifs, une voie plus large et une ligne latérale continue, associée à la nouvelle calandre Singleframe élargie, l’Audi A3 Sportback a l'air plus athlétique que jamais." },
                new images(){Title="Audi S5 Cabriolet",Url="https://www.audi.fr/content/dam/nemo/fr/Gamme/A5/Refonte-2022/S5-Cabriolet/1920x1080_S5cabriolet_motorisation_16112022.jpg?imwidth=1920",Text="L’intérieur de l'Audi S5 Cabriolet présente des éléments signatures de la gamme S, comme les sièges sport S en option, les incrustations de série en aluminium brossé mat et le volant en cuir à 3 branches à méplat et avec boutons multifonctions, l'emblème S et les coutures contrastantes assurant une ambiance sportive qui n’est pas sans rappeler l’extérieur." },

            };
            Carousel.ItemsSource = i;
        }
       

    }
}
