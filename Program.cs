using System;

namespace KarakterTerstenYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Merhaba Hello Question";
            string newSentence = "";
            string firstLetter = "";
            for (int i = 0; i <= sentence.Length; i++)
            {
                if (i == 0)
                {
                    firstLetter = sentence[i].ToString();
                }
                else if (i == sentence.Length)
                {
                    newSentence += firstLetter;
                    break;
                }
                else if (sentence[i].ToString() == " ")
                {
                    newSentence += firstLetter + " ";
                    firstLetter = sentence[i+1].ToString();
                    i++;
                    continue;
                }
                else
                {
                    newSentence += sentence[i].ToString();
                }
            }
            Console.WriteLine(newSentence);
        }
    }
}