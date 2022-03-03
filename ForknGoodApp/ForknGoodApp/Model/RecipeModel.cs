namespace ForknGoodApp.Model
{
    public class RecipeModel
    {
        public string RecipeID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string IName { get; set; }
        public string Quantity { get; set; }
        public string IName2 { get; set; }
        public string Quantity2 { get; set; }
        public string IName3 { get; set; }
        public string Quantity3 { get; set; }
        public string IName4 { get; set; }
        public string Quantity4 { get; set; }

        //public virtual IEnumerable<IngredientModel> Ingredients { get; set; }
        //Tried multiple methods to draw data from a second model but all have been unsuccesfull so far. So I have added all elements of data into a single model until I can get it to work
        //Possible solution is adding a different method to the base view model. Selection changed works for what i have here.
    }

}

//David MacDonald
