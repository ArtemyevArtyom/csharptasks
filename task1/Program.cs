Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int square = NumberB * NumberB;
if(square == NumberA)
{
    Console.WriteLine("да");
}
else
{
     Console.WriteLine("нет");
}