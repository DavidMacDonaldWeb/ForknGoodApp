using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForknGoodApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForknGoodApp.ViewModel.Tests
{
    [TestClass()]
    public class RecipeViewModelTests
    {
        [TestMethod()]
        public void RecipeViewModelTest()
        {
            RecipeViewModel viewModel = new RecipeViewModel();

            RecipeViewModel model = viewModel;

            Assert.IsNotNull(viewModel);
        }
                   
        
    }
}