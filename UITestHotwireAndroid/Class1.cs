using Xamarin.UITest;

namespace UITestHotwireAndroid
{
    public class AppInitializer
    {

        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android

                    .EnableLocalScreenshots()
                    .ApkFile(@"C:/Users/mohammed.iqbal/Desktop/APP/HotwireFision1.2.0-debug79.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}
