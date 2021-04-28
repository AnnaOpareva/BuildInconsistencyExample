using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft;
using Newtonsoft.Json;

namespace WPF.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string output = JsonConvert.SerializeObject("test");
        }
    }
}
