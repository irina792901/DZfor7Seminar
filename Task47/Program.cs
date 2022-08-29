/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,k478 7,8 -7,1 9
*/
using static System.Console;
using MyMethods;
Clear();
MyMatrixes.PrintMatrix(
     MyMatrixes.GetRealMatrix(MyArrays.InputNaturalNumber(
          "Введите количество строк m"),
          MyArrays.InputNaturalNumber(
          "Введите количество стобцов n"),
          MyArrays.InputParameters(
          "Введите через пробел минимальное и максимальное значение целочисленных элементов массива: ")
     ));