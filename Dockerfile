FROM mcr.microsoft.com/dotnet/core/sdk:2.2

WORKDIR /app

COPY /BenchmarkingAssignment/bin/Release/netcoreapp*/*  /app/

ENTRYPOINT BenchmarkingAssignment.dll