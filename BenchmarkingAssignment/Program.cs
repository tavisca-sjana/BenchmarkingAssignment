using System;
using BenchmarkDotNet.Running;
using System.Threading;

namespace BenchmarkingAssignment
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to compare between For and Foreach");
            Console.WriteLine("Enter 2 to compare between Array and List");
            Console.WriteLine("Enter 3 to compare between String and StringBuilder");
            Console.WriteLine("Enter 4 to compare between Struct and Class");
            Console.WriteLine("Enter 5 to compare between manual thread and thread pool");
            int num = int.Parse(Console.ReadLine());


            switch(num)
            {
                case 1:
                    var summary = BenchmarkRunner.Run<ForVsForeach>();
                    break;
                case 2:
                    summary = BenchmarkRunner.Run<ArrayVsList>();
                    break;
                case 3:
                    summary = BenchmarkRunner.Run<StringVsStringBuilder>();
                    break;
                case 4:
                    summary = BenchmarkRunner.Run<StructVsClass>();
                    break;
                case 5:
                    summary = BenchmarkRunner.Run<Threads>();
                    break;
               default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        
             Console.ReadKey(true);
        }

    }
}
