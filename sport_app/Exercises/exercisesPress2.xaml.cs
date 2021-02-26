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
    public partial class exercisesPress2 : ContentPage
    {
        bool alive = true;
        public exercisesPress2()
        {
            InitializeComponent();
        }

        private bool OnTimerTick()
        {
            timer.Text = DateTime.Now.ToString("T");
            return alive;
        }

        private void startTimer_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
            }
            else
            {
                alive = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
        }
    }
}