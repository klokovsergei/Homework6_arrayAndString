// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

namespace task2
{
    class Task2
    {
        static void WriteText(string str)
        {
            Console.Write(str);
        }

        static string CreateLowStringFromString(string oldStr)
        {
            return oldStr.ToLower();
        }

        static void Main(string[] args)
        {
            WriteText("Введите произвольный текс латинскими буквами в разных регистрах:\n");
            string str = Console.ReadLine()!;
            
            WriteText("Этот же текст только в нижнем регистре:\n");
            WriteText(CreateLowStringFromString(str));

        }

    }
}