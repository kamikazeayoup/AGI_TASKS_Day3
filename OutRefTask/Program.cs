// See https://aka.ms/new-console-template for more information

using OutRefTask;

int x = 4;
int y = 5;
Console.WriteLine($" X = {x} and Y = {y}");
OutRef.swapRefOut(ref x, ref y, out int RX, out int RY);
Console.WriteLine($" X = {x} and Y = {y}");
Console.WriteLine($" Out of X = {RX} and Y = {RY}");

