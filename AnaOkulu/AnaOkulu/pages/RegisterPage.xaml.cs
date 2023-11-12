using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnaOkulu.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, System.EventArgs e)
        {
            {
                DisplayAlert("Bilgi", "Kayıt işlemi tamamlandı.", "Tamam");
                Navigation.PushAsync(new LoginUI());
            }
        }

        public void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }
    }
}