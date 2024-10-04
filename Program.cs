using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Text;
using System.Globalization;
using System.Net;


public class Program
{
    public static void Main()
    {
        string ex;

        Console.WriteLine("Выберете номер задания: \n\n" +
            "1.  Дробная часть.\n" +
            "2.  Букву в число.\n" +
            "3.  Двузначное.\n" +
            "4.  Диапазон.\n" +
            "5.  Равенство.\n" +
            "6.  Модуль числа.\n" +
            "7.  Тридцать пять. \n" +
            "8.  Тройной максимум. \n" +
            "9.  Двойная сумма.\n" +
            "10. День недели.\n" +
            "11. Числа подряд.\n" +
            "12. Четные числа.\n" +
            "13. Длина числа.\n" +
            "14. Квадрат. \n" +
            "15. Правый треугольник.\n" +
            "16. Поиск первого значения.\n" +
            "17. Поиск максимального. \n" +
            "18. Добавление массива в массив.\n" +
            "19. Возвратный реверс.\n" +
            "20. Все вхождения. \n");
        ex = Console.ReadLine();
        switch (ex)
        {
            case "1":
                try
                {
                    Console.WriteLine("Задание 1.1. Метод возвращает только дробную часть числа Х.");
                    Console.Write("Введите число: ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Дробная часть числа Х: {Fraction(x1)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "2":
                try
                {
                    Console.WriteLine("Задание 1.3. Метод преобразовывает символ в соответсвующее число.");
                    Console.Write("Введите один из символов “0 1 2 3 4 5 6 7 8 9”: ");
                    char x2 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine($"Результат: {charToNum(x2)}");
                }
               catch
                {
                    Console.WriteLine("Некорректный ввод");
                }            
                break;
            case "3":
                Console.WriteLine("Задание 1.5. Метод возвращает true, если число двузначное.");
                Console.Write("Введите целое число: ");
                int x3;
                string inputx3 = Console.ReadLine();
                if (int.TryParse(inputx3, out x3))
                {
                    Console.WriteLine($"Результат: {is2Digits(x3)}");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }               
                break;
            case "4":
                try
                {
                    Console.WriteLine("Задание 1.7. Метод возвращает true, если число принадлежит заданному промежутку, включая его границы.");
                    Console.Write("Введите первую границу А: ");
                    int a4 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вторую границу В: ");
                    int b4 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число: ");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат: {isInRange(a4, b4, num4)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "5":
                try
                {
                    Console.WriteLine("Задание 1.9. Метод возвращает true, если все три введеных числа равны.");
                    Console.Write("Введите первое число А: ");
                    int a5 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число В: ");
                    int b5 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите третье число С: ");
                    int c5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат: {isEqual(a5, b5, c5)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "6":
                try
                {
                    Console.WriteLine("Задание 2.1. Метод возвращает модуль числв Х.");
                    Console.Write("Введите число: ");
                    int x6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"|X| = {abs(x6)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "7":
                try
                {
                    Console.WriteLine("Задание 2.3. Метод возвращает true, если число нацело делится на 3 или 5.");
                    Console.Write("Введите число: ");
                    int x7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат: {is35(x7)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "8":
                try
                {
                    Console.WriteLine("Задание 2.5. Метод возвращает максимальное из трех чисел");
                    Console.Write("Введите число Х: ");
                    int x8 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число Y: ");
                    int y8 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число Z: ");
                    int z8 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"X = {x8} Y = {y8} Z = {z8} \nМаксимальное число: {max3(x8, y8, z8)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "9":
                try
                {
                    Console.WriteLine("Задание 2.7. Метод возвращает сумму чисел Х и Y. Однако, если сумма попадает в диапазон от 10 до 19, то возвращает число 20.");
                    Console.Write("Введите число Х: ");
                    int x9 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число Y: ");
                    int y9 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат: {sum2(x9, y9)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "10":
                try
                {
                    Console.WriteLine("Задание 2.9. Метод возвращает строку с названием дня недели, которе соответствует введенной цифре.");
                    Console.Write("Введите число Х: ");
                    int x10 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат: {day(x10)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "11":
                try
                {
                    Console.WriteLine("Задание 3.1. Метод выводит числа от 0 до Х.");
                    Console.Write("Введите число Х: ");
                    int x11 = Convert.ToInt32(Console.ReadLine());
                    if (x11 > 0)
                    {
                        Console.WriteLine($"Результат: {listNums(x11)}");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "12":
                try
                {
                    Console.WriteLine("Задание 3.3. Метод выводит все четные числа от 0 до Х.");
                    Console.Write("Введите число Х: ");
                    int x12 = Convert.ToInt32(Console.ReadLine());
                    if (x12 > 0)
                    {
                        Console.WriteLine($"Результат: {chet(x12)}");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "13":
                try
                {
                    Console.WriteLine("Задание 3.5. Метод выводит количество знаков в числе Х.");
                    Console.Write("Введите целое число Х: ");
                    long x13 = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Результат: {numLen(x13)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "14":
                try
                {
                    Console.WriteLine("Задание 3.7. Метод выводит на экран квадрат из символа '*' размерностью x*x.");
                    Console.Write("Введите число Х: ");
                    int x14 = Convert.ToInt32(Console.ReadLine());
                    if (x14 >= 1)
                    {
                        square(x14);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "15":
                try
                {
                    Console.WriteLine("Задание 3.9. Метод выводит на экран треугольник из символов ‘*’ у которого х символов в высоту, а количество символов в ряду совпадает с номером строки, при этом треугольник выровнен по правому краю.");
                    Console.Write("Введите число Х: ");
                    int x15 = Convert.ToInt32(Console.ReadLine());
                    if (x15 >= 1)
                    {
                        rightTriangle(x15);
                    }
                    else
                    {
                        Console.WriteLine("Неекорректный ввод");
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "16":
                try
                {
                    Console.WriteLine("Задание 4.1. Метод возвращает индекс первого вхождения числа Х в массив. Если число не входит в массив – возвращается -1.");
                    Console.Write("Введите число Х: ");
                    int x16 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите размер массива: ");
                    int n16 = Convert.ToInt32(Console.ReadLine());
                    int[] arr16 = new int[n16];
                    for (int i = 0; i < n16; i++)
                    {
                        arr16[i] = new Random().Next(0, 20);
                        Console.Write(arr16[i] + " ");
                    }
                    Console.WriteLine($"\nРезультат: {findFirst(arr16, x16)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "17":
                try
                {
                    Console.WriteLine("Задание 4.3. Метод возвращает наибольшее по модулю значение массива.");
                    Console.Write("Введите размер массива: ");
                    int n17 = Convert.ToInt32(Console.ReadLine());
                    int[] arr17 = new int[n17];
                    for (int i = 0; i < n17; i++)
                    {
                        arr17[i] = new Random().Next(-30, 20);
                        Console.Write(arr17[i] + " ");
                    }
                    Console.WriteLine($"\nРезультат: {maxAbs(arr17)}");
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "18":
                try
                {
                    Console.WriteLine("Задание 4.5. Метод возвращает новый массив, который будет содержать все элементы массива arr, однако в выбранную позицию будут вставлены значения массива ins.");
                    Console.Write("Введите размер массива arr: ");
                    int n181 = Convert.ToInt32(Console.ReadLine());
                    int[] arr181 = new int[n181];
                    for (int i = 0; i < n181; i++)
                    {
                        arr181[i] = new Random().Next(0, 20);
                        Console.Write(arr181[i] + " ");
                    }
                    Console.Write("\nВведите размер массива ins: ");
                    int n182 = Convert.ToInt32(Console.ReadLine());
                    int[] ins182 = new int[n182];
                    for (int i = 0; i < n182; i++)
                    {
                        ins182[i] = new Random().Next(0, 20);
                        Console.Write(ins182[i] + " ");
                    }
                    Console.Write("\nВведите номер позиции, с которой будет добавлен массив ins: ");
                    int pos18 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат: ");
                    Console.Write(string.Join(" ", add(arr181, ins182, pos18)));
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "19":
                try
                {
                    Console.WriteLine("Задание 4.7. Метод переписывает массив в обратном порядке.");
                    Console.Write("Введите размер массива: ");
                    int n19 = Convert.ToInt32(Console.ReadLine());
                    int[] arr19 = new int[n19];
                    for (int i = 0; i < n19; i++)
                    {
                        arr19[i] = new Random().Next(0, 20);
                        Console.Write(arr19[i] + " ");
                    }
                    Console.WriteLine($"\nРезультат: ");
                    Console.Write(string.Join(" ", reverseBack(arr19)));
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
                break;
            case "20":
                try
                {
                    Console.WriteLine("Задание 4.9. Метод выводит список индексов вхождений числа x в массив arr");
                    Console.Write("Введите размер массива: ");
                    int n20 = Convert.ToInt32(Console.ReadLine());
                    int[] arr20 = new int[n20];
                    for (int i = 0; i < n20; i++)
                    {
                        arr20[i] = new Random().Next(0, 20);
                        Console.Write(arr20[i] + " ");
                    }
                    Console.Write("\nВведите число Х: ");
                    int x20 = Convert.ToInt32(Console.ReadLine());
                    if (findAll(arr20, x20).Length == 0)
                    {
                        Console.WriteLine("Число не входит в массив.");
                    }
                    else
                    {
                        Console.WriteLine($"\nРезультат: ");
                        Console.Write(string.Join(" ", findAll(arr20, x20)));
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }             
                break;
            default:
                Console.WriteLine("Такого номера нет или вы тыкнули лишний раз на пробел.");
                break;

        }
    }


    public static double Fraction(double x)
    {
        decimal dX = (decimal)x;
        decimal integerPart = Math.Truncate(dX);
        decimal fractionResult = Convert.ToDecimal(x) - integerPart; 
        return (double)fractionResult;
    }
    public static int charToNum(char x)
    {
        return (int)x - 48;
    }
    public static bool is2Digits(int x)
    {
        if (((x > 9) & (x < 100)) | ((x < -9) & (x > -100)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool isInRange(int a, int b, int num)
    {
        if (((num >= a) & (num <= b)) | ((num <= a) & (num >= b)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool isEqual(int a, int b, int c)
    {
        if ((a == b) & (b == c) & (a == c))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int abs(int x)
    {
        if (x > 0)
        {
            return x;
        }
        else
        {
            return -x;
        }
    }
    public static bool is35(int x)
    {
        if ((x % 3 == 0) | (x % 5 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int max3(int x, int y, int z)
    {
        int a;
        if (x>y)
        {
            a = x;
        }
        else
        {
            a = y;
        }
        if (a > z)
        {
            return a;
        }
        else
        {
            return z;
        }
    }
    public static int sum2(int x, int y)
    { 
        if (((x+y)>9) & ((x+y)<20))
        {
            return 20;
        }
        else
        {
            return x + y;
        }
    }
    public static String day(int x)
    {
        string day;
        switch (x)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "Это не день недели";

        }
    }
    public static String listNums(int x)
    {
        var list = new StringBuilder(); 
        for (int i = 0; i <= x; i++)
        {
            list.Append(i + " ");
        }
        return list.ToString();
    }
    public static String chet(int x)
    {
        var list = new StringBuilder();
        for (int i = 0; i <= x; i = i+2)
        {
            list.Append(i + " ");
        }
        return list.ToString();
    }
    public static int numLen(long x)
    {
        int i = 0;
        while (x > 0)
        {
            x = x / 10;
            i++;

        }
        return i;
    }
    public static void square(int x)
    {
       int i = 0;
       string s = new string('*', x);
       while (i < x)
        {
            Console.WriteLine(s);
            i++;
        }
    }
    public static void rightTriangle(int x)
    {
        int i = 0;
        while (i < x)
        {
            Console.WriteLine(new string(' ', x-i-1) + new string('*', i+1));
            i++;
        }
    }
    public static int findFirst(int[] arr, int x)
    {
        int result = -1;
        int i = 0;
        while (i < arr.Length)
        {
            if ((arr[i] == x) & (result == -1))
            {
                result = i;
            }
            
            i++;
        }
        return result;
    }
    public static int maxAbs(int[] arr)
    {
        int result = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(result))
            {
                result = arr[i];
            }
        }
        return result;
    }
    public static int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];

        Array.Copy(arr, 0, result, 0, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        return result;
    }
    public static int[] reverseBack(int[] arr)
    {
        int k;
        for (int i = 0; i < (arr.Length/2); i++)
        {
            k = arr[i];
            arr[i] = arr[arr.Length-i-1];
            arr[arr.Length - i - 1] = k;
        }
        return arr;
    }
    public static int[] findAll(int[] arr, int x)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result.Add(i);
            }
        }
        
        int[] res = result.ToArray();    
        return res;
    }

}
 