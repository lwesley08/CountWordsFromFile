using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\WeCanCodeIT\Documents\BadgerMushroomSnake.txt");
           
            string[] wordsInText = text.Split();

            List<string> uniqueWords = new List<string>();

            foreach (string word in wordsInText)
            {
                if (!uniqueWords.Contains(word))
                {
                    uniqueWords.Add(word);
                }
            }

            List<string> printInfoArray = new List<string>();

            foreach(string word in uniqueWords)
            {
                string printOutInfo = word + " : ";
                //Console.Write(word + " : ");
                foreach(string sameword in wordsInText)
                {
                    if(word == sameword)
                    {
                        //Console.Write("*");
                        printOutInfo += ("*");
                    }
                    
                }
                printInfoArray.Add(printOutInfo);
                //Console.WriteLine();
            }

           printInfoArray = printInfoArray.OrderBy(x => x.Length).Reverse().ToList();

            foreach(string item in printInfoArray)
            {
                Console.WriteLine(item);
            }

           
        }
    }
}
