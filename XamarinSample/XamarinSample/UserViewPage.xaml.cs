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
            int numberOne = Convert.ToInt32(number1Entry.Text);
            int numberTwo = Convert.ToInt32(number2Entry.Text);
            sumLabel.Text = "The sum of these two numbers is: " + (numberOne + numberTwo);
        }
    }
}