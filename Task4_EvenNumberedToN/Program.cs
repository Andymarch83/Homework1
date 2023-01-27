Console.WriteLine("Введите число N: ");

string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = 2; i <= number; i++)
if ((i % 2) == 0)
{
  Console.Write($"{i},");
}

