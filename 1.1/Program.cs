/*    Напишите программу, которая перевернёт массив с элементами в обратном порядке
(первый элемент будет на последнем месте, а последний на первом)   */



int s = 6, miAr = 0, maAr = 33;
int[] mass = MassivNew(s, miAr, maAr);
System.Console.WriteLine($"[{String.Join(" ", mass)}]");
int[] svaip = MassivNaoborot(mass);
System.Console.WriteLine($"[{String.Join(" ", svaip)}]");
MassivNaoborot2(mass);
System.Console.WriteLine($"[{String.Join(" ", mass)}]");




int[] MassivNew(int size, int minAr, int maxAr)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minAr, maxAr);
  }
  return array;
}

int[] MassivNaoborot(int[] elov)
{
  int[] massN = new int[elov.Length];
    for (int i = 0; i < elov.Length; i++)
  {
    massN[i] = elov[elov.Length -1 - i];
  }
  return massN;
}

void MassivNaoborot2(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
  {
    int min = array[i];
     array[i] = array[array.Length - 1 - i];
     array[array.Length - 1 - i] = min;    // проходим циклом и 
  }
}
