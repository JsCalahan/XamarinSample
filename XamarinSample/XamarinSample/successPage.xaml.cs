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
    public partial class successPage : ContentPage
    {
        public successPage()
        {
            InitializeComponent();
        }

        private void SuccessPageBackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}