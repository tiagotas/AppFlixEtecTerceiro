using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFlixEtecTerceiro.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PanteraNegra : ContentPage
    {
        public PanteraNegra()
        {
            InitializeComponent();

            poster.Source = ImageSource.FromResource("AppFlixEtecTerceiro.Posters.panteranegra.jpg");


            trailer.Source = new HtmlWebViewSource()
            {
                Html = @"<iframe 
                                width='400' 
                                height='300' 
                                src='https://www.youtube.com/embed/wL4a4MafSjQ' 
                                title='YouTube video player' 
                                frameborder='0' 
                                allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
                                allowfullscreen>
                            </iframe>"
            };
            
            /*youtube.Html = @"<iframe 
                                width='400' 
                                height='300' 
                                src='https://www.youtube.com/embed/wL4a4MafSjQ' 
                                title='YouTube video player' 
                                frameborder='0' 
                                allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
                                allowfullscreen>
                            </iframe>";

            trailer.Source = youtube;*/


            lbl_sipnopse.Text = "Conheça a história de T'Challa, príncipe do reino de Wakanda, "
                              + "que perde o seu pai e viaja para os Estados Unidos, onde tem contato com os Vingadores. "
                              + "Entre as suas habilidades estão a velocidade, inteligência e os sentidos apurados.";
        }
    }
}