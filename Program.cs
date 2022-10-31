using System;

var n = Console.ReadLine().Length;

var sum = 0;
for (int i = 0; i < n; i++)
    for (int j = 0; j < 2; j++)
        sum++;

Console.WriteLine(sum); 