﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 1; i <= 100; i++) {
    Console.Write(i + " ");
    if (i % 3 == 0) {
        Console.Write("Fizz");
    }
    if (i % 5 == 0) {
        Console.Write("Buzz");
    }
    Console.WriteLine();
}