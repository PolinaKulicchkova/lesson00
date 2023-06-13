Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt16(Console.ReadLine());

int i = -number;
while(i <= number)
{
    Console.WriteLine(i);
    ++i;
}