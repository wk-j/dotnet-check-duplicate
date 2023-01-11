# Check Duplicate

```
dotnet run -c Release --project src/CheckDuplicate
```

```
| Method            | N       |         Mean |      Error |       StdDev |     Gen0 |     Gen1 |     Gen2 |  Allocated |
| ----------------- | ------- | -----------: | ---------: | -----------: | -------: | -------: | -------: | ---------: |
| HashSetCheck      | 1000    |     10.89 us |   0.212 us |     0.198 us |        - |        - |        - |          - |
| LinqDistinctCheck | 1000    |     22.84 us |   0.446 us |     1.160 us |   6.1340 |        - |        - |    25776 B |
| HashSetCheck      | 10000   |    111.88 us |   0.915 us |     0.812 us |        - |        - |        - |          - |
| LinqDistinctCheck | 10000   |    268.87 us |   2.351 us |     1.963 us |  66.4063 |  66.4063 |  66.4063 |   280573 B |
| HashSetCheck      | 100000  |  1,124.18 us |   7.020 us |     5.862 us |        - |        - |        - |        2 B |
| LinqDistinctCheck | 100000  |  2,290.82 us |  24.267 us |    21.512 us | 332.0313 | 332.0313 | 332.0313 |  2505902 B |
| HashSetCheck      | 1000000 | 11,937.25 us | 123.192 us |   109.207 us |        - |        - |        - |       15 B |
| LinqDistinctCheck | 1000000 | 28,405.93 us | 563.703 us | 1,138.707 us | 312.5000 | 312.5000 | 312.5000 | 26790126 B |
```