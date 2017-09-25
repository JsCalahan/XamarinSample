using System;
using System.Collections.Generic;
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

        public List<string> Movies { get; set; }
        public ListViewPage()
        {
            InitializeComponent();

            this.Movies = new List<string>();
        }

        private void AddMovieButton_Clicked(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(newMovieEntry.Text))
            {
                DisplayAlert("Error", "Entry is empty.", "Ok");
            }
            this.Movies.Add(newMovieEntry.Text);

            newMovieEntry.Text = "";

            moviesListView.ItemsSource = this.Movies;
        }

        private void ClearMoviesButton_Clicked(object sender, EventArgs e)
        {
            Movies.Clear();
            moviesListView.ItemsSource = new List<string>();
        }
    }
}