# Check Duplicate

```
dotnet run -c Release --project src/CheckDuplicate
```

```
| Method            | N       |         Mean |      Error |     StdDev |
| ----------------- | ------- | -----------: | ---------: | ---------: |
| HashSetCheck      | 1000    |     10.94 us |   0.119 us |   0.093 us |
| LinqDistinctCheck | 1000    |     22.88 us |   0.451 us |   0.554 us |
| HashSetCheck      | 10000   |    120.17 us |   2.065 us |   3.724 us |
| LinqDistinctCheck | 10000   |    272.83 us |   3.530 us |   3.130 us |
| HashSetCheck      | 100000  |  1,131.18 us |   8.561 us |   8.008 us |
| LinqDistinctCheck | 100000  |  2,306.77 us |  22.114 us |  19.603 us |
| HashSetCheck      | 1000000 | 11,866.07 us |  71.303 us |  55.669 us |
| LinqDistinctCheck | 1000000 | 28,867.19 us | 239.700 us | 212.487 us |
```