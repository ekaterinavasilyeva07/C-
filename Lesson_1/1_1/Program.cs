// See https://aka.ms/new-console-template for more information



Console.Write("Enter number 1: ");
int b1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Enter number 2: ");
int b2 = Convert.ToInt32(Console.ReadLine()!);
if (b1 * b1 == b2)
    Console.WriteLine ("Yes");
else 
    Console.WriteLine ("No");