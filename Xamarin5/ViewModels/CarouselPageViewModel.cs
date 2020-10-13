using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin5.Models;

namespace Xamarin5.ViewModels
{
    public class CarouselPageViewModel : BindableBase, IInitialize
    {
        private ObservableCollection<Banner> _banners;
        public ObservableCollection<Banner> Banners
        {
            get
            {
                return _banners;
            }
            set
            {
                SetProperty(ref _banners, value);
            }

        }

        private Banner _currentItem;
        public Banner CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                SetProperty(ref _currentItem, value);
            }
        }

        public CarouselPageViewModel()
        {
        }

        public void Initialize(INavigationParameters parameters)
        {
            Banners = new ObservableCollection<Banner>();
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/21jumpstreet.jpg", Title = "21 jumpstreet" });
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/300fond_0.jpg", Title = "300" });
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/20-VersionTamoul_2.jpg", Title = "Version Tamoul" });
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/1917FOND2_0.jpg", Title = "1917" });
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/full-1379409jpg-r_1920_1080-f_jpg-q_x-xxyxx.jpg", Title = "Sans un bruit" });
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/full-image1.jpeg", Title = "Spiderman" });
            Banners.Add(new Banner { ImageUrl = "https://legrandrex.com/images/films/thedarkknight.png", Title = "The Dark Nigth" });
        }
    }
}
