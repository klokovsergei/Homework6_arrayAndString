// Задайте произвольную строку. Выясните, является ли она палиндромом.

namespace task3
{
    class Task3
    {
        static void WriteText(string str)
        {
            Console.Write(str);
        }

        // static bool PolindromCheckString(string oldStr)
        // {
        //     bool polindrom = true;
        //     string str = oldStr.ToLower();
        //     //if (str == string.Empty) break;
        //     int sizeStr = str.Length;
        //     int j = sizeStr - 1;
        //     for (int i = 0; i <= sizeStr / 2; i++, j--)
        //         polindrom = polindrom && (str[i] == str[j]);
        //     return polindrom;
        // }

        static bool PolindromCheckString(string oldStr)
        {
            bool polindrom = true;
            string str = oldStr.ToLower();
            //if (str == string.Empty) break;
            int sizeStr = str.Length;
            for (int i = 0, j = sizeStr - 1; i <= sizeStr / 2; i++, j--)
                polindrom = polindrom && (str[i] == str[j]);
            return polindrom;
        }

        static void Main(string[] args)
        {
            WriteText("Введите слово, чтобы проверить является ли оно полиндромом:\n");
            string str = Console.ReadLine()!;
            
            Console.WriteLine(PolindromCheckString(str));

        }

    }
}