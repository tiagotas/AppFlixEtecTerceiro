using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFlixEtecTerceiro.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            btnCapitaMarvel.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.capitamarvel.jpg");
            btnAlladin.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.alladin.jpg");
            btnDumbo.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.dumbo.jpg");
            btnJoker.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.joker.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.panteranegra.jpg");
            btnReiLeao.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.reileao.jpeg");
            btnShazan.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.shazam.jpg");
            btnVef.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.vef.jpg");
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitaMarvel());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK :( ");
            }

        }

        private void btnPanteraNegra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.PanteraNegra());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK :( ");
            }

        }
    }
}