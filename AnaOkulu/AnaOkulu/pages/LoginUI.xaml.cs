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
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
       
        public void Button_Clicked(object sender, System.EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                Navigation.PushAsync(new TabbedPage1());
            }
            else
            {
                DisplayAlert("Hata", "Kullanici adı veya şifre hatalı !", "Tamam");
            }
        }

        public void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
        
    }
}