using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sport_app.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class training : ContentPage
    {
        public training()
        {
            InitializeComponent();
        }

        private async void chest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises.chest());
        }

        private async void press_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises.press());
        }

        private async void legs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises.legs());
        }

        private async void buttocks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises.buttocks());
        }

        private async void hands_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises.hands());
        }

        private void own_training_Clicked(object sender, EventArgs e)
        {

        }
    }
}