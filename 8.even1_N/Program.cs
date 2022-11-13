Console.Write("input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int index = 1;
while (index <= num1)
{
    if (index % 2 == 0)
        Console.Write(index + " ");
    index++;
}
