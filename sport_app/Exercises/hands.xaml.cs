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

        public class exercises
        {
            public string Title { get; set; }
            public string ImagePath { get; set; }
        }
    }
}