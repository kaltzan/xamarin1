﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            button.Clicked += Button_Clicked;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            string name = entry.Text;
            await DisplayAlert("Hi there", $"Hello {name}", "OK");

        }
    }
}
