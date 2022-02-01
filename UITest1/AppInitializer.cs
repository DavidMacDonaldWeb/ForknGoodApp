using System;
using System.AddIn.Hosting;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }

        internal static IAppDomainSetup StartApp(Platform platform)
        {
            throw new NotImplementedException();
        }

        internal static IApp StartApp(object forknGoodApp)
        {
            throw new NotImplementedException();
        }
    }
}