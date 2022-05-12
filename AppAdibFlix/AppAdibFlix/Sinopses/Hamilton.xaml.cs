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
    public partial class Hamilton : ContentPage
    {
        public Hamilton()
        {
            InitializeComponent();

            Hamilton.Source = ImageSource.FromResource("AppAdibFlix.Posters.hamilton.jpg");

        }
    }
}