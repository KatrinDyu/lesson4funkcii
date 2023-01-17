//summa cifr v chisle

/* Console.Clear();
Console.WriteLine("vvedite chislo");
int chislo = int.Parse(Console.ReadLine());
int k = 0;
for (int i= 0; i <= 99999; i++)
{
   int ost = chislo % 10;
    chislo = chislo / 10;
    k = k + ost;
}
Console.WriteLine($"summa cifr {k}"); */

Console.Clear();
Console.WriteLine("vvedite chislo");
int chislo = int.Parse(Console.ReadLine());

int SummCifr(int chisl)
{
    int k = 0;
    for (int i= 0; i <= 99999; i++)
    {
     int ost = chisl % 10;
      chisl = chisl / 10;
      k = k + ost;
    }
    return k;
}
Console.WriteLine($"summa cifr {SummCifr(chislo)}");