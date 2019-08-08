using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkingAssignment
{
    public class StringVsStringBuilder
    {
        [Benchmark]
        public void StringBenchmark()
        {
            string s = "";
            for(int i=0;i<1000;i++)
                s += "Hello";
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
