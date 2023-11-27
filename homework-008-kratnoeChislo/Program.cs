Console.WriteLine("Write you number");
int n = int.Parse(Console.ReadLine()!);

if((n % 7 == 0) && (n % 23 ==0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}