using ForknGoodApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForknGoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void View_Clicked(object sender, EventArgs e) //Method for the button that draws the recipe page
        {
            Navigation.PushAsync(new RecipesPage());
        }

    }
}
//David MacDonald