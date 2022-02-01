using ForknGoodApp.Model;
using ForknGoodApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForknGoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipesPage : ContentPage
    {
        public RecipesPage()
        {
            InitializeComponent();
          
        }

       /* private void OnItemSelected(object sender, ItemTappedEventArgs e) //Old command used to diplay details page before learning about selection command. Left in for future writing
        {
            Navigation.PushAsync(new DetailsPage());
          
        }*/
    }

}

//David MacDonald