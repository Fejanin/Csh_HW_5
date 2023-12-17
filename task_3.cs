/******************************************************************************
Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
*******************************************************************************/

void Main() {
    int[,] nums = new int[,] { 
        { 21, 22, 23 }, 
        { 4, 5, 6 },
        { 7, 8, 9 }
    };
    int[] sums = new int[nums.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            sum += nums[i, j];
        }
        sums[i] = sum;
        sum = 0;
    }
    int res = sums[0];
    int ind = 0;
    for (int i = 1; i < sums.Length; i++) {
        if (sums[i] < res) {
            res = sums[i];
            ind = i;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой находиться под индексом - " + ind);
}

Main()
