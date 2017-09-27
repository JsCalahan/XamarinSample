using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {

        public ObservableCollection<string> Movies { get; set; }
        public ListViewPage()
        {
            InitializeComponent();

            this.Movies = new ObservableCollection<string>();
        }

        private void AddMovieButton_Clicked(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(newMovieEntry.Text))
            {
                DisplayAlert("Error", "Entry is empty.", "Ok");
            }
            else
            {
                this.Movies.Add(newMovieEntry.Text);
                moviesListView.ItemsSource = this.Movies;
                newMovieEntry.Text = "";
            }
        }

        private void ClearMoviesButton_Clicked(object sender, EventArgs e)
        {
            this.Movies.Clear();
            moviesListView.ItemsSource = new List<string>();
        }

        public void OnDelete(object sender, EventArgs e)
        {
            MenuItem mi = ((MenuItem)sender);
            string item = mi.CommandParameter.ToString();

            this.Movies.Remove(item);
            moviesListView.ItemsSource = this.Movies;
            //Movies.Remove(sender as string);
            //moviesListView.ItemsSource = Movies;
        }

        private void moviesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem ==null)
            {
                return;
            }

            string item = e.SelectedItem.ToString();
            ((ListView)sender).SelectedItem = null;
            Navigation.PushAsync(new movieInfoPage(item));
            
        }
    }
}