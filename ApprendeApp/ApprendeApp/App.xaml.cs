﻿using System;

using ApprendeApp.Views;
using Xamarin.Forms;

namespace ApprendeApp
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();
            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.IoniconsModule())
                                  .With(new Plugin.Iconize.Fonts.MaterialModule());
            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
