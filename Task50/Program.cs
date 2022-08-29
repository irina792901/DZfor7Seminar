/*Задача 50. Напишите программу, которая на вход
 принимает позиции элемента в двумерном массиве, 
 и возвращает значение этого элемента или же 
 указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/

using static System.Console;
using MyMethods;
int[,] integerMatrix = MyMatrixes.GetIntegerMatrix(
    MyArrays.GetIntegerNumber(),
    MyArrays.GetIntegerNumber(),
    MyArrays.Input("Введите минимальное значние элемента"),
    MyArrays.Input("Введите максимальное значение элемента")
    );
MyMatrixes.FindElementByIndex(
    MyArrays.InputParameters(
        "Введите через пробел индекс строки и индекс столбца двумерного массива: "), 
        integerMatrix);
WriteLine("Был загадан массив:");
MyMatrixes.PrintMatrix(integerMatrix);
