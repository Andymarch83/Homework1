Console.WriteLine("Введите первое число: ");
string numberOneStr = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneStr);
Console.WriteLine("Введите второе число: ");
string numberTwoStr = Console.ReadLine();
int numberTwo = Convert.ToInt32(numberTwoStr);
Console.WriteLine("Введите третье число: ");
string numberThreeStr = Console.ReadLine();
int numberThree = Convert.ToInt32(numberThreeStr);
int max = numberOne;
if(numberTwo > max )
{
 max = numberTwo;
if(numberThree > max)
max = numberThree;
}
Console.Write("max = ");
Console.WriteLine(max);