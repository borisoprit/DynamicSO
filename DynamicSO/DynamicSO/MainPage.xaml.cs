using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DynamicSO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Image1.Style = (Style)Resources["selectedStyle"];
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Image1.Style = (Style)Resources["defaultStyle"];
        }
    }
}
