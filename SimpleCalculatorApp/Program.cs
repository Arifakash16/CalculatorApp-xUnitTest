// See https://aka.ms/new-console-template for more information
using SimpleCalculatorApp;

Console.WriteLine("Hello, World!");
Calculator calculator = new Calculator();
var result = calculator.Add(5, 6);
Console.WriteLine("result = " + result);