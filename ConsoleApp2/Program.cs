// Ввод координат точки
Console.WriteLine("Введите x=");
float x = float.Parse(Console.ReadLine());
Console.WriteLine("Введите y=");
float y = float.Parse(Console.ReadLine());
// Проверка на границу
if ((y == x + 2 && x >= -2 && x <= 0) || (y == -x + 2 && x >= 0 && x <= 2) || (y == 0 && x >= -2 && x <= 2))
{
    Console.WriteLine("Точка на границе");
}
// Проверка внутри области
else if (x >= -2 && x <= 2 && y >= 0 && y <= 2 && y <= x + 2 && y <= -x + 2)
{
    Console.WriteLine("Точка входит в область");
}
// Если ни одно условие не выполнено, значит, точка вне области
else
{
    Console.WriteLine("Точка не входит в область");
}
