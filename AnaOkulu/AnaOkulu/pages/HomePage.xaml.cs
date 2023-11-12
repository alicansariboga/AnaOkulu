using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnaOkulu.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public class ImageInformation
        {
            public ImageSource _Image { get; set; }
        }
        private ObservableCollection<ImageInformation> imageCollection;
        public ObservableCollection<ImageInformation> ImageCollection
        {
            get { return imageCollection; }
            set 
            { 
                imageCollection = value;
                OnPropertyChanged();
            }
        }

        public HomePage()
        {
            InitializeComponent();
            Title = "Ana Okulu";

            BindingContext = this;
            ImageCollection = new ObservableCollection<ImageInformation>
            {
                new ImageInformation { _Image= "image1.jpg"},
                new ImageInformation { _Image= "image2.jpg"},
                new ImageInformation { _Image= "image3.png"},
                new ImageInformation { _Image= "image4.jpg"},
                new ImageInformation { _Image= "image5.jpg"}
            };

        }
    }
}