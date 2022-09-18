// See https://aka.ms/new-console-template for more information
using GenericProb;
using System;
Console.WriteLine("Hello, World!");
int a = 10;
int b = 20;
int c = 30;
MaxNumber maxNumber = new MaxNumber();
//Console.WriteLine(maxNumber.PrintdMaxNumber(a,b,c));
int val = maxNumber.PrintdMaxNumber<int>(a, b, c);
Console.WriteLine("Max Number is: "+val);
Console.ReadLine();