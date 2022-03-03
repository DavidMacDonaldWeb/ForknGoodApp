using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForknGoodApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ForknGoodApp.Views.Tests
{
    [TestClass()]
    public class DetailsPageTests
    {
        [TestMethod()]
        public void Return_Recipes()
        {
            var recipes = new ObservableCollection<int>
            {
                1
            };

            Assert.IsTrue(recipes.Count.Equals(1));
        }

}