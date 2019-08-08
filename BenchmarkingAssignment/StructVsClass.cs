using BenchmarkDotNet.Attributes;

namespace BenchmarkingAssignment
{

    public struct StructToBeBenchmarked
    {
        public int roll;
        public string name;
    }

    public class ClassToBeBenchmarked
    {
        public int roll { get; set; }
        public string name { get; set; }

    }
    public class StructVsClass
    {
        [Benchmark]
        public void ClassOperation()
        {
            var data = new ClassToBeBenchmarked[1000];
            for(int i=0;i<1000;i++)
            {
                data[i] = new ClassToBeBenchmarked() { roll = 1, name = "scott" };
            }
        }

        [Benchmark]
        public void StructOperation()
        {
            var data = new StructToBeBenchmarked[1000];
            for (int i = 0; i < 1000; i++)
            {
                data[i] = new StructToBeBenchmarked() { roll = 1, name = "scott" };
            }
        }
    }
}
