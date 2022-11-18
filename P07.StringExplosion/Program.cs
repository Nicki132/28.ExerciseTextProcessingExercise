using System;
using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currCh = inputStr[i];

                if (currCh == '>')
                {
                    int currBombPower = GetCharacterIntValue(inputStr[i + 1]);
                    outputText.Append(currCh);
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(currCh);
                    }
                }
            }
            Console.WriteLine(outputText.ToString());
        }

        static int GetCharacterIntValue(char ch)
        {
            return (int)ch - 48;
        }
    }
}
