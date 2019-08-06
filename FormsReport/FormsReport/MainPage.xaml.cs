using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsReport
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void SwitchButton_Clicked(object sender, EventArgs e)
        {
            var page = new Switch();
            await Navigation.PushAsync(page);
        }

        async void SliderButton_Clicked(object sender, EventArgs e)
        {
            var page = new Slider();
            await Navigation.PushAsync(page);
        }

        async void StepperButton_Clicked(object sender, EventArgs e)
        {
            var page = new Stepper();
            await Navigation.PushAsync(page);
        }
    }
}
