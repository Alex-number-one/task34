int size = new Random().Next(1, 10);
int[] array = new int[size];
  int j = 1;
  int sum = 0;
for (int i = 0; i < size; i++)
{
   
    
    array[i] = new Random().Next(1, 10);
    if (j % 2 != 0)
    {
       sum += array[i];
        
    }
      j++;
  Console.Write( array[i] + " ");
  
}
Console.Write("-> " + sum);


