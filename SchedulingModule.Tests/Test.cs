using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingModule.Tests
{
    class Test
    {
        public void Test1()
        {
            var test = new JsonSelectSettings();
            string output = JsonConvert.SerializeObject("Test");
        }
    }
}
