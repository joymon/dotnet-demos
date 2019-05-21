using Bogus;
using System;
using System.Collections.Concurrent;

namespace TimeTakenTestServer.Repositories
{
    class DataRepository
    {
        static ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
        internal string GetTestData(int sizeInMB)
        {
            string result;
            if(dict.TryGetValue(sizeInMB,out result))
            {
                
            }
            else
            {
                result = GenerateTestData(sizeInMB);
                dict.TryAdd(sizeInMB, result);
            }
            return result;
        }

        private string GenerateTestData(int sizeInMB)
        {
            var strings = new Bogus.DataSets.Lorem();
            // 1 sentence seems 200 bytes
            return strings.Paragraphs(sizeInMB * 5 * 1000);
        }
    }
}
