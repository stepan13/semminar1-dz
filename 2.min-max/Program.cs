Console.Write("input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
    Console.WriteLine("numbers are equal");
else if (num1 > num2)
    Console.WriteLine("max = " + num1 + " min = " + num2);
else
    Console.WriteLine("max = " + num2 + " min = " + num1);

