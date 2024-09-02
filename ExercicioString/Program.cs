using System;

class Program
{
    static void Main()
    {
        string phrase = "Rato roeu a roupa do rei de Roma";
        CountLetterA(phrase);
    }

    static void CountLetterA(string phrase)
    {
        int count = 0;

        foreach (char character in phrase)
        {
            if (character == 'a' || character == 'A')
            {
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("Não há a presença do 'a' nessa palavra");
        }
        else
        {
            Console.WriteLine($"Apareceu {count} vezes");
        }
    }

}