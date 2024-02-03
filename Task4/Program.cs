// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

namespace task4
{
    class Task4
    {
        static void WriteText(string str)
        {
            Console.Write(str);
        }

        static string[] CreateStringArrFromString(string str)
        {
            string[] strArr = str.Split(' ');
            return strArr;
        }

        static string ReversWordsInText(string str)
        {
            string[] strArr = CreateStringArrFromString(str);
            string[] newStrArr = new string[strArr.Length];
            int i = newStrArr.Length - 1;
            foreach(string j in strArr)
            {
                newStrArr[i] = j;
                i--;
            }
            return string.Join(" ", newStrArr);
        }

        static void Main(string[] args)
        {
            WriteText("Введите любую фразу для деления на слова (разделитель пробел):\n");
            string str = Console.ReadLine();
            
            WriteText(ReversWordsInText(str));

        }

    }
}