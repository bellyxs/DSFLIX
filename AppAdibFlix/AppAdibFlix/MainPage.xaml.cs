using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
 
namespace AppAdibFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            EtecFlix.Source = ImageSource.FromResource("AppAdibFlix.Posters.etecflix.png");
            btnEternos.Source = ImageSource.FromResource("AppAdibFlix.Posters.eternos.png");
            btnDoctor.Source = ImageSource.FromResource("AppAdibFlix.Posters.doctor.png");
            btnBatman.Source = ImageSource.FromResource("AppAdibFlix.Posters.batman.png");
            btnSpiderman.Source = ImageSource.FromResource("AppAdibFlix.Posters.miranha.png");
            btnRed.Source = ImageSource.FromResource("AppAdibFlix.Posters.red.png");
            btnHamilton.Source = ImageSource.FromResource("AppAdibFlix.Posters.hamilton.jpg");
            btnHeathers.Source = ImageSource.FromResource("AppAdibFlix.Posters.heathers.png");
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

        private void btnSpiderman_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new Sinopses.Spiderman());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");

            }
        }

        private void btnRed_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new Sinopses.Red());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnHamilton_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new Categorias.Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnHeathers_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new Categorias.Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
        


