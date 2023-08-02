// See https://aka.ms/new-console-template for more information

using OutRefTask;

int x = 4;
int y = 5;
OutRef.swapRef(ref x, ref y);
Console.WriteLine($" X = {x} and Y = {y}");
OutRef.swapOut(x, y, out int RX, out int RY);
Console.WriteLine($" X = {RX} and Y = {RY}");
