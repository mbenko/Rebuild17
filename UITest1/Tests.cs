using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
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
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void FirstThingsFirst()
        {
            app.Screenshot("Screenshot");
            app.TouchAndHold(x => x.Text("Milwaukee"));
            app.Tap(x => x.Text("Save Changes"));
            app.Tap(x => x.Class("EntryEditText"));
            app.EnterText(x => x.Class("EntryEditText"), "Helllo world");
            app.Tap(x => x.Text("Add"));
            app.Tap(x => x.Text("Add"));
            app.Screenshot("Tapped on view with class: AppCompatButton with text: Add");
            app.PressEnter();
            app.TouchAndHold(x => x.Text("VS 2017 Best Of Launch").Index(1));
            app.Tap(x => x.Text("Save Changes"));
            app.SwipeLeftToRight();
            app.Screenshot("Swiped right");
            app.Tap(x => x.Class("MasterDetailPageRenderer"));
        }

    }
}

