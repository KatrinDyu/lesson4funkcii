Console.Clear();
int [] mass = new int[8];
int i = 0;
for (i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 9);
    Console.Write($"[{String.Join(", ", mass[i])}]");
}
