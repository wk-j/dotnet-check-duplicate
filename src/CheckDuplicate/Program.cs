using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

[MemoryDiagnoser()]
public class DupChecker {
    [Params(1000, 10000, 100000, 1000000)]
    public int N;
    private List<int> numbers;
    private HashSet<int> uniqueNumbers;

    [GlobalSetup]
    public void Setup() {
        numbers = Enumerable.Range(0, N).ToList();
        numbers.AddRange(Enumerable.Range(0, N / 2));
        uniqueNumbers = new HashSet<int>();
    }

    [Benchmark]
    public int HashSetCheck() {
        int duplicateCount = 0;
        uniqueNumbers.Clear();
        for (int i = 0; i < numbers.Count; i++) {
            if (!uniqueNumbers.Add(numbers[i]))
                duplicateCount++;
        }
        return duplicateCount;
    }

    [Benchmark]
    public int LinqDistinctCheck() {
        int duplicateCount = numbers.Count - numbers.Distinct().Count();
        return duplicateCount;
    }
}

class Program {
    static void Main(string[] args) {
        // var summary = BenchmarkRunner.Run<DupChecker>();
        var config = ManualConfig.Create(DefaultConfig.Instance);
        var summary = BenchmarkRunner.Run<DupChecker>(config);
    }
}
