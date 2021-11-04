// метод выборки
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого згачения со значением первой неотсортированной позиции.
// 3. Повторить пока есть не отсортированные элементы.

int[] arr = { 1, 5, 6, 7, 7, 9, 3, 2, 4};

void PrintArray(int[] array)
{
        int count =array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; i++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);