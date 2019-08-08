``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-6500U CPU 2.50GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2531245 Hz, Resolution=395.0625 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                 Method |       Mean |     Error |     StdDev |
|----------------------- |-----------:|----------:|-----------:|
|         ArrayBenchmark |   932.6 ns |  10.01 ns |   9.359 ns |
|          ListBenchmark | 2,784.8 ns |  29.75 ns |  27.824 ns |
| StringBuilderBenchmark | 8,022.3 ns | 149.19 ns | 153.207 ns |
