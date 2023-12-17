/*
Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/


void Main() {
    int[,] nums = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
    Console.Write("Введите индекс строки: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Введите индекс колоноки: ");
    int col = int.Parse(Console.ReadLine());
    if (row >= 0 & row < nums.GetLength(0)) {
        if (col >= 0 & col < nums.GetLength(1)) {
            Console.WriteLine(nums[row, col]);
        }
    } else {
        Console.WriteLine("Нет элемента с такими индексами.");
    }
}


Main();
