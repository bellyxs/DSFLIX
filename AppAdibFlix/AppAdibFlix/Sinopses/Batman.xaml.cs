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
    public partial class Batman : ContentPage
    {
        public Batman()
        {
            InitializeComponent();

            batman.Source = ImageSource.FromResource("AppAdibFlix.Posters.batman.png");



        }

    }
}