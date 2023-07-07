int size = 6;
int [] array = new int [size];
int min = 11;
int max = 0;
for (int  i = 0; i < size; i++)
{
    array[i] = new Random().Next(1 , 10);
     
    
if (array[i] < min)
{
    min = array[i];
}
if (array[i] > max)
{
    max = array[i];
}




     Console.Write(array[i] + " ");
}
Console.Write($" -> {max - min}");