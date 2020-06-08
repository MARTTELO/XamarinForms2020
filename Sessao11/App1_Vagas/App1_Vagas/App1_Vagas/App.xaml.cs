﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Vagas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new App1_Vagas.Paginas.ConsultaVagas());
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
