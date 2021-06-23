using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public interface IFeatureFlag
    {
        Task<bool> GetFeatureFlagValue(string featureFlagName);
    }
    public class FeatureFlag: IFeatureFlag
    {
        public Task<bool> GetFeatureFlagValue(string featureFlagName)
        {
            //Random random = new Random();
            //int num = random.Next(1000);
            //for (int i = 0; i < num; i++)
            //{ }
            //int number = random.Next(1000);
            //for (int i = 0; i < number; i++)
            //{ }
            //if (number > num)
            //{
            //    return Task.FromResult(true);
            //}
            //else
            //{
            //    return Task.FromResult(false);
            //}
            return Task.FromResult(true);
        }
    }
}
