Console.WriteLine("Введите первое число: ");
string numberOneStr = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneStr);
Console.WriteLine("Введите второе число: ");
string numberTwoStr = Console.ReadLine();
int numberTwo = Convert.ToInt32(numberTwoStr);
if(numberOne > numberTwo)
{
    Console.Write("max = " );
    Console.WriteLine(numberOne);
}
else 
Console.Write("max = ");
Console.WriteLine(numberTwo);