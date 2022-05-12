using System;
using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Sinopses
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Doctor : ContentPage
    {
        public Doctor()
        {
            InitializeComponent();

            doctor.Source = ImageSource.FromResource("AppAdibFlix.Posters.doctor.png");

        }
    }
}