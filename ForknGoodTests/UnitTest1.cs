using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ForknGoodApp;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using ForknGoodApp.ViewModel;

namespace ForknGoodTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetRecipes_IdIsOne_ReturnOk()
        {
            //Arrange
            var controller = new RecipeController();

            //Act
            var result = controller.GetRecipes(1)

            //Assert
            Assert.That(result, IsTypeOf<RecipeViewModel>());
        }
    }
}
