namespace Tests
{
    using System.IO;
    using FlaUI.UIA3;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var path = Path.GetFullPath("../../../../RTCLauncher/bin/Debug/RTC_Launcher.exe");
            var app = FlaUI.Core.Application.Launch(path);
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
            }
            app.Close();
        }
    }
}
