using App3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3.ViewModels
{
    public class PlayersViewModel : BindableObject
    {
        /// <summary>
        /// Players starts empty. It is filled on a background thread.
        /// This allows page to display quickly, though at first it lacks Players.
        /// </summary>
        /// <returns></returns>
        public static PlayersViewModel CreateDeferred()
        {
            //DataSource vm = new DataSource();
            PlayersViewModel vm = new PlayersViewModel();

            // Empty list for initial display.
            vm.Players = new ObservableCollection<Player>();

            // This version runs on Main Thread.
            Device.BeginInvokeOnMainThread(async () => await vm.LoadPlayers());

            // Returns before LoadPlayers is finished.
            return vm;
        }

        public ObservableCollection<Player> Players { get; set; }

        /// <summary>
        /// "private". Only call this via static method.
        /// </summary>
        private PlayersViewModel()
        {
            
        }

        public async Task LoadPlayers()
        {
            List<Player> players = await PrefetchPlayers();
            Players = new ObservableCollection<Player>(players);
            OnPropertyChanged(nameof(Players));
        }
        public static async Task<List<Player>> PrefetchPlayers()
        {
            var players = new List<Player>();

            for (int iPlayer = 0; iPlayer < 2; iPlayer++)
            {
                // Simulate query time. Remove from production code.
                await Task.Delay(2000);
                Player player = new Player();
                player.Id = iPlayer;
                player.Texte = "Player " + iPlayer;
                player.Description = "Discription " + iPlayer;

                players.Add(player);
            }
            return players;

        }
    }

}
