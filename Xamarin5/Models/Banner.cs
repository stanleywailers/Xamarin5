using System;
using Prism.Mvvm;

namespace Xamarin5.Models
{
    public class Banner : BindableBase
    {
        private string _imageUrl;
        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
            set
            {
                SetProperty(ref _imageUrl, value);
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetProperty(ref _title, value);
            }
        }
    }
}
