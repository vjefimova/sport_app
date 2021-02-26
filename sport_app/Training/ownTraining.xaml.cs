using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sport_app.Training
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ownTraining : ContentPage
    {
        public ObservableCollection<grouping<string, exercises>> exercisesGroups { get; set; }
        public List<exercises> exercise { get; set; }
        public ownTraining()
        {
            InitializeComponent();
            /*exercise = new List<exercises>
            {
                new exercises {Title="Махи с согнутой ногой", ImagePath="mahi.png" },
                new exercises {Title="Планка «пила»", ImagePath="planka.png" }
             };
            this.BindingContext = this;*/

            /*exerciseHand = new List<exercises>
            {
                new exercises {Title="Обратные отжимания на скамье", ImagePath="hands1.png" },
                new exercises {Title="Алмазные отжимания", ImagePath="hands2.png" },
                new exercises {Title="Разворот в планке на предплечье", ImagePath="hands3.png" }
             };
            exercisesHandList.BindingContext = this;*/
        }

        /*private async void exercisesList_ItemTapped(object sender, ItemTappedEventArgs e)
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
        }*/
    }
}