using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserViewPage());
        }

        private void ListViewButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
        }

        private void GridButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Grids());
        }
    }
}
