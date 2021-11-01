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


int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue,maxValue);
}

int[] A = new int[20];

int index=0;
        while(index<20)
        {
            A[index] = GetRandom(10,100);
            index++;
        }

index = 0;
        while(index<20)
        {
            Console.WriteLine(A[index] +" ");
            index++;
        }

Console.WriteLine();
index = 1;
int firstelement = A[0];
Console.WriteLine(A[0]);
while(index<10)
{
   if(A[index]>firstelement)
      {
          Console.WriteLine(A[index]);
           firstelement = A[index];    
      }
    
    index++;
}