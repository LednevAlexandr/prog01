//Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. Создать на его основе масив B, отбрасывая те, которые
//нарушают порядок возрастания
//больше среднего арифметического элементов A
//чётные
// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные

// Метод заполнения масива случайными чисалми
void CreatureArray(int[] array, int minValue, int maxValue)
{
         int i=0;
         while (i < array.Length) 
         {
              array[i] = new Random().Next(minValue, maxValue);
              i++;
         }
}
// Метод вывода масива на экран
void PrintArray(int[] arr)
{
    int j=0;
    while (j<arr.Length)
{
         Console.WriteLine(arr[j]);
         j++;
    }
}

// Метод создания масива с сортировкой
void sortArray(int[] arr)
{
int CurrentElement = arr[0];
Console.WriteLine(arr[0]);
int index=1;
while (index<arr.Length)
{
    if(arr[index]>CurrentElement)
    {
    Console.WriteLine(arr[index]);
    CurrentElement=arr[index];
    }
    index++;
}
}
// ввод размера масива. Но не получилось до конца, почему то в масиве k не видит() !!!!!!
int inputArray()
{
    int k;
    Console.Write("Введите размер масива: ");
    k=Convert.ToInt32(Console.ReadLine());
    
    return k;
}

// Среднее арефметическое масива

int Average(int[] arr)
{
    int count = 0;
    int summa = 0;
    int mean;
    while (count<arr.Length)
    {
         summa = summa + arr[count];
         count++;
    }
mean = summa / arr.Length;
return mean; 

}

// сортировка - отбрасывать больше среднего арефмитического (метод в методе)

void Sorted(int[] arr)
{
    int i=0;
    while (i<arr.Length)
    {
         if(arr[i]<Average(arr))
         {
          Console.WriteLine(arr[i]);

         }
         i++;
    }
}

int[] array = new int[10];
//inputArray();
CreatureArray(array,10,100);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Average(array));
Console.WriteLine();
//sortArray(array);
Sorted(array);
//Average(array);