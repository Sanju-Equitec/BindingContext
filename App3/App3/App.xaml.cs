using App3.Models;
using App3.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        //public static string Title
        //{
        //    get { return Title; }
        //    set
        //    {
        //        Title = value;
               
        //    }
        //}
        public App()
        {
            InitializeComponent();

            MainPage = new PlayersPage();
            //OnPropertyChanged("value1");

        }

        protected override void OnStart()
        {
            //List<Player> players = await PlayersViewModel.PrefetchPlayers();
            //var page = new PlayersPage();
            //page.SetPlayers(players);
            //MainPage = page;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
