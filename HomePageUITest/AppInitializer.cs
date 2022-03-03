using Xamarin.UITest;

namespace HomePageUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                   // .ApkFile ("/Users/david/source/repos/ForknGoodApp - First Phase (Don't delete)/ForknGoodApp/ForknGoodApp.Android/bin/Debug")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}