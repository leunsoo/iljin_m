﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iljin_m.Views;

namespace iljin_m
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StockSch();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
