﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LockMe.Views.Component
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextButton : ContentView
    {
        public NextButton()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocalNotificationPage());
        }
    }
}