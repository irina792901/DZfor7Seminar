using System;
using System.Linq;
using static System.Console;
namespace MyMethods;
public class MyMatrixes
{
 
    public static int[,] GetIntegerMatrix(int rows, int colums, int minValue, int maxValue)
    {
        int[,] result = new int[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return result;
    }


    public static double[,] GetRealMatrix(int lines, int top, int[] parametersArray)
    {
        double[,] result = new double[lines, top];
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < top; j++)
            {
                result[i, j] = Math.Round(new Random().Next(parametersArray[0], parametersArray[1] + 1) +
                new Random().NextDouble(), 2);
            }
        }
        return result;
    }

///<summary>
///вещественная матрица
///</summary>
    public static void PrintMatrix(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]}   ");
            }
            WriteLine();// возврат каретки
        }
    }
///<summary>
///целочисленная матрица
///</summary>
  public static void PrintMatrix(int[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]}   ");
            }
            WriteLine();// возврат каретки
        }
    }


public static void FindElementByIndex(int[] indexes, int[,] inArray)
{
    if ((inArray.GetLength(0)<indexes[0])
    || (inArray.GetLength(1)<indexes[1]))
    {
    WriteLine("Такого элемента нет");
    }
    else WriteLine(inArray[indexes[0],indexes[1]]);
}


public static double[] FindArithmeticMeanOfColumns(int[,] integerMatrix)
{
    int count = integerMatrix.GetLength(1);
    int index = integerMatrix.GetLength(0);
    double[] result = new double[count];
    for (int i = 0; i < count; i++)
    {
        int sum = 0;
        for (int j = 0; j < index; j++)
        {
            sum +=integerMatrix[j, i];

        }
        result[i]= (double)sum/index;
    }
    return result;
}



}


