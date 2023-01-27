using System.Diagnostics;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            string text = File.ReadAllText("C:\\Users\\cavva\\OneDrive\\Рабочий стол\\Text1.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] splitedText = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            List<string> words = new List<string>();
            stopwatch.Start();
            words.AddRange(splitedText);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();
            LinkedList<string> linkedWords = new LinkedList<string>();

            foreach (var word in splitedText)
            {
                linkedWords.AddLast(word);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            //Связный список не позволяет добавлять сразу массив данных одной операцией, а добавление по одной строке с помощью цикла неэффективно, поэтому в таких ситуациях лучше использовать обычный лист или же просто массив стрингов.
        }
    }
}