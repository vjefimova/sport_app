﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sport_app.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class buttocks : ContentPage
    {
        public string[] exercise { get; set; }
        public buttocks()
        {
            InitializeComponent();
            exercise = new string[] { "Приседания", "Выпады", "Поднимание ягодиц из положения лежа" };
            this.BindingContext = this;
        }

        private void exercisesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}