using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sport_app.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class press : ContentPage
    {
        public List<exercises> exercise { get; set; }

        public press()
        {
            InitializeComponent();
            exercise = new List<exercises>
            {
                new exercises {Title="Махи с согнутой ногой", ImagePath="mahi.png" },
                new exercises {Title="Планка «пила»", ImagePath="planka.png" }
             };
            this.BindingContext = this;
        }

        private async void exercisesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            exercises selectedExercise = e.Item as exercises;
            if (selectedExercise.Title.ToString() == "Махи с согнутой ногой")
            {
                await Navigation.PushAsync(new exercisesPress1());
            }
            if (selectedExercise.Title.ToString() == "Планка «пила»")
            {
                await Navigation.PushAsync(new exercisesPress2());
            }
        }
    }
}