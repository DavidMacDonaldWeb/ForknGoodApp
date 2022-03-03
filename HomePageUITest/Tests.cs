﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HomePageUITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp (platform);
        }

            [Test]
            public void AppLaunchingFirstTimeTest()
            {
            AppResult[] matchedItems =
            app.Query(c => c.Button().Marked("VIEW RECIPES"));

            app.Repl ();

            }
        

    }
}