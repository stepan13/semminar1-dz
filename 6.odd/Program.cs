Console.Write("input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
    Console.WriteLine($"number {num1} is even");
else
    Console.WriteLine($"number {num1} is odd");
