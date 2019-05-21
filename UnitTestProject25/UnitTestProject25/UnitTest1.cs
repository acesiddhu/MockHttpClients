using System;
using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.TestResults.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject25
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var m1 = Mock.Of<GitHttpClient>();
            //var m = Mock.Get(m1);
            var m = new Mock<GitHttpClient>(new Uri("https://mseng.visualstudio.com"), null);
            //var m1 = new Mock<BuildHttpClient>(new Uri("https://mseng.visualstudio.com"), null);
            var o = m.Object;
            //var o1 = m1.Object;

            //m.SetupAllProperties();

        }
    }
}
