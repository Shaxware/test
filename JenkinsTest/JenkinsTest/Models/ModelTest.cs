using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace JenkinsTest.Models
{
    [TestFixture(Description="JenkinsのNUnit動作テストを行います")]
    public class ModelTest
    {
        [Test(Description="OKのケース")]
        public void TestOK()
        {
        }

        [Test(Description ="NGのケース")]
        public void TestNG()
        {
            // test6
            Assert.Fail();
        }
    }
}