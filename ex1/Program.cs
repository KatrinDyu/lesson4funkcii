Console.Clear();
Console.WriteLine("vvedite a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("vvedite b");
int b = int.Parse(Console.ReadLine());
int stepen = a;
for (int i =1; i <= (b - 1); i++)
{
    stepen = stepen * a;
}
Console.WriteLine($"a v stepeni b {stepen}");
