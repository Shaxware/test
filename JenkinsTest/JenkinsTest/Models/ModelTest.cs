using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace JenkinsTest.Models
{
    [TestFixture(Description="JenkinsのNUnit動作テストを行います。")]
    public class ModelTest
    {
        [Test(Description="OKのケース")]
        public void TestOK()
        {
        }

        [Test(Description ="NGをOKに修正のケース")]
        public void TestNG()
        {
            // GitHub Pull Request Builder Pluginで、
            // コミット&プッシュのケースを試してみる
            // 再度
            //           Assert.Fail();
        }
    }
}