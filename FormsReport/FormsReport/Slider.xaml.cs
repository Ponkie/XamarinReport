using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();
            colorbox.Color = Color.FromRgb(0, 0, 0);
        }


        private void Color_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            colorbox.Color = Color.FromRgb((int)redslider.Value, (int)greenslider.Value, (int)blueslider.Value);
        }
    }
}