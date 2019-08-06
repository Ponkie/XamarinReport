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
    public partial class Stepper : ContentPage
    {
        public Stepper()
        {
            InitializeComponent();
            stepper.Value = 0;
        }

        //private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    lblStepperValue.Text = string.Format("The value of the stepper is {0}", stepper.Value);
        //    lblStepperValue.Rotation = stepper.Value;
        //}
    }
}