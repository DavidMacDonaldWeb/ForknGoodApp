using ForknGoodApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ForknGoodApp.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    {
        private ObservableCollection<RecipeModel> recipes;

        /*public ObservableCollection<IngredientModel> Ingredients { get; set; }*/
 
        public ObservableCollection<RecipeModel> Recipes
        {
            get { return recipes; }
            set
            {
                recipes = value;
                OnPropertyChanged();
            }
        }
       /* private IngredientModel selectedIngredient;
        public IngredientModel SelectedIngredient                                                         //All ingredient items are previous code that is being saved for future attempts at a cleaner display
        {
            get { return selectedIngredient; }
            set
            {
                selectedIngredient = value;
                OnPropertyChanged();
            }
        }*/
        private RecipeModel selectedRecipe;
        public RecipeModel SelectedRecipe
        {
            get { return selectedRecipe; }
            set
            {
                selectedRecipe = value;
                OnPropertyChanged();
            }
        }
       
        private int position;

        public int Position
        {
            get
            {
                if (position != recipes.IndexOf(selectedRecipe))    //Returns the details of the recipe selected, to be used in the details view
                   
                    return recipes.IndexOf(selectedRecipe);


                return position;
            }
            set
            {
                position = value;
                selectedRecipe = recipes[position];
              

                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }
    }
            
}


//David MacDonald