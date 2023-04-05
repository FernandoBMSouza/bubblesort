int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
BubbleSort(array);
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = i + 1; j < array.Length; j++)
            if (array[i] > array[j])
            {
                int aux = array[i];
                array[i] = array[j];
                array[j] = aux;
            }
}