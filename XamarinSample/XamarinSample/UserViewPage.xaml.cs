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
    public partial class UserViewPage : ContentPage
    {
        public UserViewPage()
        {
            InitializeComponent();
        }

        private void nameButton_Clicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(number1Entry.Text);
            int number2 = Convert.ToInt32(number2Entry.Text);
            sumLabel.Text = "The sum of these two numbers is: " + (number1 + number2);
        }
    }
}