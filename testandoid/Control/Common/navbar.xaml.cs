using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testandoid.Control.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class navbar : ContentPage
    {
        public navbar()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("hghghg", "gfgfg", "Cancel");
        }
    }
}