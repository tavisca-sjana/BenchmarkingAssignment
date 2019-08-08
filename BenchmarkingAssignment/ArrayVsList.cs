using BenchmarkDotNet.Attributes;
using System.Text;
using System.Collections.Generic;

namespace BenchmarkingAssignment
{
    public class ArrayVsList
    {
        [Benchmark]
        public void ArrayBenchmark()
        {
            int [] data = new int [1000];
           for(int i = 0; i < 1000; i++)
            {
                data[i] = i;
            }
        }

        [Benchmark]
        public void ListBenchmark()
        {
            List<int> data = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                data.Add(i);
            }
        }



        [Benchmark]
        public void StringBuilderBenchmark()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < 1000; i++)
                s.Append("Hello");

        }

    }
}
