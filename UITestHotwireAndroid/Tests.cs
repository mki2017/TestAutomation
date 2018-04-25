using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITestHotwireAndroid
{
    [TestFixture(Platform.Android)]
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
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void HotwirePostLogin()
        {
            app.Screenshot("First screen.");

            app.WaitForElement(x => x.Id("btn_signup"), timeout: TimeSpan.FromSeconds(90));
            app.Screenshot("OnBoard Screen with Signup button");
            app.ScrollDown();
            app.Tap(x => x.Id("btn_signup"));


            app.WaitForElement(x => x.Marked("button_get_started"), timeout: TimeSpan.FromSeconds(90));
            Assert.AreEqual("Sign Up Now", app.Query("title")[0].Text);
            app.Screenshot("Get Started button displays");
            app.Tap(x => x.Marked("button_get_started"));
        }
    }
}

