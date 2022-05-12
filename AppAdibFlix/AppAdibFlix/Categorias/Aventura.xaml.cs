using AppAdibFlix.Sinopses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btnEternos.Source = ImageSource.FromResource("AppAdibFlix.Posters.eternos.png");
            btnBatman.Source = ImageSource.FromResource("AppAdibFlix.Posters.batman.png");
            btnDoctor.Source = ImageSource.FromResource("AppAdibFlix.Posters.doctor.png");
        }

        private void btnEternos_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Sinopses.eternos());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnDoctor_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Sinopses.Doctor());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnBatman_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Sinopses.Batman());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");

            }
        }

    }
}
            
        
    

