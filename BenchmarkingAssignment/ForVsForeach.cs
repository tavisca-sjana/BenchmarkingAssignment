using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchmarkingAssignment
{
    public class ForVsForeach
    {
        private List<int> data = new List<int>();
        public ForVsForeach()
        {
            for(int i=0;i<1000;i++)
            {
                data.Add(i);
            }
        }
        
        [Benchmark]
        public void ForBenchmark()
        {
            int x;
            for(int i=0;i<1000;i++)
            {
                x = data[i];
            }
        }

        [Benchmark]
        public void ForeachBenchmark()
        {
            int x;
            foreach(var item in data)
            {
                x = item;
            }

        }

    }
}
