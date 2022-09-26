// Упорядочить массив
// Алгоритм сортировки методом выбора (алгоритм сортировки мин и мах)
// Задача: Имеется последовательность чисел 6 8 3 2 1 4 5 7
// необходимо упорядочить по возрастанию.
// Алгоритм:
// 1. Найти позицию мин элемента в неотсортированной части массива
// 2. Произвести обмен этого элемента со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int [] arr = {6, 8, 3, 2, 1, 4, 5, 7,};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort (int [] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array [i] = array[minPosition];
        array[minPosition] = temporary;

    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
