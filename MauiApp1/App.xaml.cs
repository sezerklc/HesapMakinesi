﻿namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NewPage1();//new AppShell();
        }
    }
}
