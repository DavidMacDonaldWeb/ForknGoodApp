using ForknGoodApp.Model;
using ForknGoodApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ForknGoodApp.ViewModel
{
    public class RecipeViewModel : BaseViewModel
    {
        public RecipeViewModel()
        {

            recipes = GetRecipes();
        }
        /*ObservableCollection<IngredientModel> ingredients;
        public ObservableCollection<IngredientModel> Ingredients       //Method that was tried in a cleaner way to display the ingredient model
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
                OnPropertyChanged();
            }
        }*/
        ObservableCollection<RecipeModel> recipes;
        public ObservableCollection<RecipeModel> Recipes //returns the recipes from the recipe model 
        {
            get { return recipes; }
            set
            {
                recipes = value;
                OnPropertyChanged();
            }
        }


        private RecipeModel selectedRecipe;
        public RecipeModel SelectedRecipe              //Gets the recipe selected and returns its value for the details page
        {
            get { return selectedRecipe; }
            set
            {
                selectedRecipe = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectionCommand => new Command(DisplayRecipe);//Selection command for details page. 

        private void DisplayRecipe()
        {
            if (selectedRecipe != null)
            {
                DetailsViewModel viewModel = new DetailsViewModel { SelectedRecipe = selectedRecipe, Recipes = recipes, Position = recipes.IndexOf(selectedRecipe) };//Tells the details page what to look for
                DetailsPage detailsPage = new DetailsPage { BindingContext = viewModel };//Binds the data to be used on the details page

                NavigationPage navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(detailsPage, true);
            }
        }



        private ObservableCollection<RecipeModel> GetRecipes()//Gets data to display from models
        {
            return new ObservableCollection<RecipeModel>
            {
                new RecipeModel
                {
                    RecipeID = "1",
                    Name = "Golden syrup flapjacks",
                    Image = "flapjacks.png",
                    IName = "Jumbo Porridge Oats",
                    Quantity = "125g",                                    //All <IngredientModel> have been saved for future use. I find using a second model a cleaner way of developemnt 
                    IName2 = "Butter",                                    // but all techniques have failed so far
                    Quantity2 = "125g",
                    IName3 = "Golden-syrup",
                    Quantity3 = "2-3 tbsp"
                  },  
                    
                    /*Ingredients = new List<IngredientModel>()
                    {
                        new IngredientModel { IName = "Jumbo Porridge Oats", Quantity = "125g", Type = "Baking" },
                        new IngredientModel { IName = "Butter", Quantity = "125g", Type = "Dairy" },
                        new IngredientModel { IName = "Golden-syrup", Quantity = "2-3 tbsp", Type = "Condiments" }
                    }*/
               

                new RecipeModel
                {
                    RecipeID = "2",
                    Name = "Creamy tomato courgetti",
                    Image = "corgetti.png",
                    IName = "Parma Ham",
                    Quantity = "4 slices",
                    IName2 = "Basil",
                    Quantity2 = "12 leaves",
                    IName3 = "Tomato and Mascapone sauce",
                    Quantity3 = "350g",
                    IName4 = "Courgetti",
                    Quantity4 = "250g",

                    /*Ingredients = new List<IngredientModel>()
                    {
                        new IngredientModel { IName = "Parma Ham", Quantity = "4 slices", Type = "Meat" },
                        new IngredientModel { IName = "Basil", Quantity = "12 leaves", Type = "Herb" },
                        new IngredientModel { IName = "Tomato and Mascapone sauce", Quantity = "350g", Type = "Condiments" },
                        new IngredientModel { IName = "Courgetti", Quantity = "250g", Type = "Veg" }
                    }*/
                },

                new RecipeModel
                {
                    RecipeID = "3",
                    Name = "Butter bean & chorizo stew",
                    Image = "Chorizo.png",
                    IName = "Chorizo",
                    Quantity = "200g",
                    IName2 = "Chopped Tomatoes",
                    Quantity2 = "400g",
                    IName3 = "drained Butter beans",
                    Quantity3 = "400g",
                    IName4 = "Pesto",
                    Quantity4 = "20g",

                    /*Ingredients = new List<IngredientModel>()
                    {
                        new IngredientModel { IName = "Chorizo", Quantity = "200g", Type = "Meat" },
                        new IngredientModel { IName = "Chopped Tomatoes", Quantity = "400g", Type = "Veg" },
                        new IngredientModel { IName = "drained Butter beans", Quantity = "400g", Type = "Condiment" },
                        new IngredientModel { IName = "Pesto", Quantity = "20g", Type = "Condiment" }

                    }*/
                },

                new RecipeModel
                {
                    RecipeID = "4",
                    Name = "Prawn & leek frittata",
                    Image = "frittata.png",
                    IName = "Large Leeks",
                    Quantity = "3",
                    IName2 = "Raw peeled King prawns",
                    Quantity2 = "150g",
                    IName3 = "Large Eggs",
                    Quantity3 = "5",
                    IName4 = "Garlic & herb cream cheese",
                    Quantity4 = "120g",


                   /* Ingredients = new List<IngredientModel>()
                    {
                        new IngredientModel { IName = "Large Leeks", Quantity = "3", Type = "Veg" },
                        new IngredientModel { IName = "Raw peeled King prawns", Quantity = "150g", Type = "Shellfish" },
                        new IngredientModel { IName = "Large Eggs", Quantity = "5", Type = "Dairy" },
                        new IngredientModel { IName = "Garlic & herb cream cheese", Quantity = "120g", Type = "Dairy" },

                    }*/
                }

            };

        }

        /*David MacDonald*/

    }

}
