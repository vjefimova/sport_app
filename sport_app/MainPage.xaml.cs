﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace sport_app
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}
