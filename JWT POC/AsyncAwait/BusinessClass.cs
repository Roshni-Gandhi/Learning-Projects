using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class BusinessClass
    {
        private readonly FeatureFlag ffProvider;
        public BusinessClass(FeatureFlag ffProvider)
        {
            this.ffProvider = ffProvider;
        }
        

        public async Task<bool> DoSomething()
        {
            //bool result2 = await this.ffProvider.GetFeatureFlagValue("ff2");
            if ((await this.ffProvider.GetFeatureFlagValue("ff1")) && (await this.ffProvider.GetFeatureFlagValue("ff2")))
            {
                Console.WriteLine("Hi");
            }
            return true;
        }
    }
}
