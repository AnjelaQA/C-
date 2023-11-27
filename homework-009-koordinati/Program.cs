Console.WriteLine("Write coordinates of x and y");
Console.WriteLine("Write coordinates of X = ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write coordinates of y = ");
int y = int.Parse(Console.ReadLine()!);


if(x == 0 || y== 0)
{
    Console.WriteLine("Пожалуйста, Выберите точки отличное от 0");
}

else if(x>0 && y>0)
{
    Console.WriteLine(" точка находится в четвертой координатной четверти");
}

else if(x < 0 && y > 0)
{
    Console.WriteLine("точка находится во второй координатной четверти");
}

else if(x < 0 && y < 0)
{
    Console.WriteLine("точка находится в третьей координатной четверти");
}

else 
{
    Console.WriteLine("точка находится в первой координатной четверти");
}