//prinimaet 2 chisla i vozvodit a v

/* Console.Clear();
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
 */

 Console.Clear();
 int Stepen(int x, int y)
{
    int stepn = x;
    for (int i =1; i <= (y - 1); i++)
    {
       stepn = stepn * x;
    }
    return stepn;
}
Console.WriteLine("vvedite a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("vvedite b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"a v stepeni b {Stepen(a, b)}");
