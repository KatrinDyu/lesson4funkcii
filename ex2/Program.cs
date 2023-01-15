Console.Clear();
Console.WriteLine("vvedite chislo");
int chislo = int.Parse(Console.ReadLine());
int k = 0;
for (int i= 0; i <= 3; i++)
{
   int ost = chislo % 10;
    chislo = chislo / 10;
    k = k + ost;

}
Console.WriteLine($"summa cifr {k}");