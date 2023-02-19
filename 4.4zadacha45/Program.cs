// *Задача 45: 
// Напишите программу, которая будет создавать копию заданного массива 
//  с помощью поэлементного копирования.

int[] b = GetArray(10, 0, 40);
Console.WriteLine(String.Join(" ", b));
int[] s = CopyMass(b);
Console.WriteLine(String.Join(" ", s));


int[] GetArray(int size, int minValue, int maxValue)
{
  int[] ds = new int [size];
  for(int i = 0; i < size; i++)
  {
    ds[i] = new Random().Next(minValue, maxValue);

  }
  return ds;
}

int[] CopyMass(int[] arra)
{
  int[] result = new int[arra.Length];
  for(int i = 0; i<arra.Length; i++)
  {
    result[i] = arra[i];
  }
  return result;
}