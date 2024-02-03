// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System.Runtime.InteropServices;

namespace task1
{
    class Task1
    {
        static char[,] CreateCharsArray(int rows, int cols)
        {
            char[,] chars = new char[rows, cols];
            return chars;
        }

        static char[,] CreateAndRandomFillCharsArray(int rows, int cols)
        {
            char[,] chars = CreateCharsArray(rows, cols);
            Random rnd = new Random();
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    chars[i, j] = (char)rnd.Next((int)'a', (int)'z');
                }
            }
            return chars;
        }

        static void ShowCharArray(Char[,] chars)
        {
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                Console.Write("[\t");
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.Write("{0}\t",chars[i, j]);
                }
                Console.WriteLine("\t]");
            }
        }

        static void WriteText(string str)
        {
            Console.Write(str);
        }

        static string CreateStringFromCharsArray(char[,] chars)
        {
            string str = String.Empty;
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    str += chars[i, j];
            return str;
        }

        static void Main(string[] args)
        {
            WriteText("Введите размер символьного массива [ X ,   ]: ");
            int rows = int.Parse(Console.ReadLine()!);
            WriteText("Введите размер символьного массива [   , X ]: ");
            int cols = int.Parse(Console.ReadLine()!);

            char[,] chars = CreateAndRandomFillCharsArray(rows, cols);
            
            Console.Clear();
            WriteText("Рандомно заполненный массив:\n");
            ShowCharArray(chars);

            WriteText($"Строка, которая сформирована из символьного массива:\n{CreateStringFromCharsArray(chars)}");

        }

    }
}