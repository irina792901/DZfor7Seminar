namespace MyMethods;
using static System.Console;
public class MyArrays
{
    public static int GetIntegerNumber()
    {
        return new Random().Next(1, 20);
    }

   
///<summary>
///получить из запроса натуральное число
///</summary>
    public static int InputNaturalNumber(string text)
    {
        int result = 0;
        while (result <= 0)
        {
            WriteLine($"Введите {text} двумерного массива: ");
            result = int.Parse(ReadLine()!);
        }
        return result;
    }
    
///<summary>
///получить из запроса целое число
///</summary>
    public static int Input(string text)
    {
        WriteLine($"Введите {text} двумерного массива: ");
        int result = int.Parse(ReadLine()!);
        return result;
    }

    public static int[] InputParameters(string text)
    {
        WriteLine(text);
        int[] result = ReadLine()!
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(x => int.Parse(x))
             .ToArray();
        return result;
    }





}
