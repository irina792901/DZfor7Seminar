/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
using MyMethods;
int[,] integerMatrix = MyMatrixes.GetIntegerMatrix(5, 8, 0, 10);
MyMatrixes.PrintMatrix(integerMatrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(";  ", MyMatrixes.FindArithmeticMeanOfColumns(integerMatrix))}");



