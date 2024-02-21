// int n = 10;
int[] array = { 2, 3, 0, 1, -34, 35, 8, 54, 11, 42 };
int i = 0;

while (i < array.Length)
{
  if (array[i] % 2 == 0)
  {
    Console.Write($"{array[i]} ");
  }
  i = i + 1;
}
