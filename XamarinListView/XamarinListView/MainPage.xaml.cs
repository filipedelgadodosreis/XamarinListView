using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinListView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<Clube> Clubes { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            CarregarClubes();
        }

        private void CarregarClubes()
        {
            Clubes = new List<Clube>();

            Clubes.Add(new Clube
            {
                Nome = "Corinthians",
                Divisao = "Serie A",
                ImageUrl = "https://allsportsphotoagency.com/wp-content/uploads/2019/04/logo-do-corinthians-256.png"
            });

            Clubes.Add(new Clube
            {
                Nome = "Internacional",
                Divisao = "Serie A",
                ImageUrl = "https://static.lojadointer.com.br/0.0.394.2/lojadointer/images/share.png"
            });

            Clubes.Add(new Clube
            {
                Nome = "Cruzeiro",
                Divisao = "Serie B",
                ImageUrl = "https://logodetimes.com/times/cruzeiro/logo-cruzeiro-256.png"
            });

            Clubes.Add(new Clube
            {
                Nome = "Guarani",
                Divisao = "Serie B",
                ImageUrl = "https://logodetimes.com/times/guarani/logo-guarani-256.png"
            });

            Clubes.Add(new Clube
            {
                Nome = "Avai",
                Divisao = "Serie B",
                ImageUrl = "https://p1.hiclipart.com/preview/361/299/711/brasileirao-iconkit-2009-avai-png-clipart.jpg"
            });

            Clubes.Add(new Clube
            {
                Nome = "Coritiba",
                Divisao = "Serie A",
                ImageUrl = "https://p1.hiclipart.com/preview/386/454/423/brasileirao-iconkit-2009-coritiba-png-clipart.jpg"
            });

            Clubes.Add(new Clube
            {
                Nome = "Atletico MG",
                Divisao = "Serie A",
                ImageUrl = "https://allsportsphotoagency.com/wp-content/uploads/2019/04/logo-atletico-mineiro-256.png"
            });

            Clubes.Add(new Clube
            {
                Nome = "Ituano",
                Divisao = "Serie C",
                ImageUrl = "https://logodetimes.com/times/ituano/logo-ituano-256.png"
            });

            Clubes.Add(new Clube
            {
                Nome = "Caxias RS",
                Divisao = "Serie D",
                ImageUrl = "https://logodetimes.com/times/caxias-do-sul/logo-caxias-do-sul-256.png"
            });

            BindingContext = this;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Clube selectedItem = e.SelectedItem as Clube;

            await DisplayAlert("Alert", "Você clicou no time " + selectedItem.Nome, "OK");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Clube tappedItem = e.Item as Clube;
        }
    }
}
