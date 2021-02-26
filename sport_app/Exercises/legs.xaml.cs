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
    public partial class legs : ContentPage
    {
        public List<exercises> exercise { get; set; }

        public legs()
        {
            InitializeComponent();
            exercise = new List<exercises>
            {
                new exercises {Title="Приседания", ImagePath="prisedania.png" },
                new exercises {Title="Боковые приседания на месте", ImagePath="bokovie.png" }
             };
            this.BindingContext = this;
        }

        private async void exercisesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            exercises selectedExercise = e.Item as exercises;
            if (selectedExercise.Title.ToString() == "Приседания")
            {
                await Navigation.PushAsync(new exercisesLegs1());
            }
            if (selectedExercise.Title.ToString() == "Боковые приседания на месте")
            {
                await Navigation.PushAsync(new exercisesLegs2());
            }
        }
    }
}