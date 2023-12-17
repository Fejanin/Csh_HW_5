/******************************************************************************
Задача 2: Задайте двумерный массив. Напишите программу, которая 
поменяет местами первую и последнюю строку массива.
*******************************************************************************/

void Main() {
    int[,] nums = new int[,] { 
        { 1, 2, 3 }, 
        { 4, 5, 6 },
        { 7, 8, 9 }
    };
    for (int row = 0; row < nums.GetLength(0); row++) {
        for (int col = 0; col < nums.GetLength(0); col++) {
            Console.Write(nums[row, col] + "\t");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {   
            if (i > 0 && i < nums.GetLength(1))
            {
                int temporary = nums[i, j];
                nums[i, j] = nums[i, j];
                nums[i, j] = temporary;
            }
            else
            {
                int temporary = nums[i, j];
                nums[i, j] = nums[(nums.GetLength(1) - 1), j];
                nums[(nums.GetLength(1) - 1), j] = temporary;
            }
        }
    }
    Console.WriteLine("Меняем местами первую и последнюю строку массива.");
    for (int row = 0; row < nums.GetLength(0); row++) {
        for (int col = 0; col < nums.GetLength(0); col++) {
            Console.Write(nums[row, col] + "\t");
        }
        Console.WriteLine();
    }
}

Main()
