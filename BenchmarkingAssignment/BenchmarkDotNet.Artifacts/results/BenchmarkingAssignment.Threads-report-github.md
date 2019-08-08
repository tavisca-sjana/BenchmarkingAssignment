``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-6500U CPU 2.50GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2531251 Hz, Resolution=395.0616 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|             Method |           Mean |       Error |      StdDev |
|------------------- |---------------:|------------:|------------:|
|   ManageThreadPool | 7,015,625.6 us | 6,413.43 us | 5,999.13 us |
| ManageManualThread |       648.9 us |    12.70 us |    15.12 us |
