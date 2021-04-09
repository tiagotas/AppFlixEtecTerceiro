using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFlixEtecTerceiro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Img.xamarin.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK :( ");
            }
        }
    }
}
