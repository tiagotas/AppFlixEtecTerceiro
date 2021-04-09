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
    public partial class CapitaMarvel : ContentPage
    {
        public CapitaMarvel()
        {
            InitializeComponent();

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' 
                                        height='300' 
                                        src='https://www.youtube.com/embed/_q3SH0dr17k' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen></iframe>";

            video_trailer.Source = htmlSource;
        }
    }
}