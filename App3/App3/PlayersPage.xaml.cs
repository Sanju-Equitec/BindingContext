using App3.Models;
using App3.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayersPage : ContentPage
    {
        public PlayersPage()
        {
            InitializeComponent();
             
            BindingContext = PlayersViewModel.CreateDeferred();
        }
    }
}