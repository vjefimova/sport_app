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
    public partial class hands : ContentPage
    {
        public List<exercises> exercise { get; set; }

        public hands()
        {
            InitializeComponent();
            exercise = new List<exercises>
            {
                new exercises {Title="Обратные отжимания на скамье", ImagePath="hands1.png" },
                new exercises {Title="Алмазные отжимания", ImagePath="hands2.png" },
                new exercises {Title="Разворот в планке на предплечье", ImagePath="hands3.png" }
             };
            this.BindingContext = this;
        }

        private async void exercisesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            exercises selectedExercise = e.Item as exercises;
            if (selectedExercise.Title.ToString() == "Обратные отжимания на скамье")
            {
                await Navigation.PushAsync(new exercisesHands1());
            }
            if (selectedExercise.Title.ToString() == "Алмазные отжимания")
            {
                await Navigation.PushAsync(new exercisesHands2());
            }
            if (selectedExercise.Title.ToString() == "Разворот в планке на предплечье")
            {
                await Navigation.PushAsync(new exercisesHands3());
            }
        }
    }
}