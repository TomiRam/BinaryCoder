using System;
using System.Text;

class Program
{
    static void Main()
    {
        string binaryInput = "01000111 01101111 01100100 01101100 01101001 01101011 01100101 00100000 01110000 01101000 01111001 01110011 01101001 01110001 01110101 01100101 00100000 01000110 01101001 01101110 01100001 01101110 01100011 01101001 01100001 01101100 00100000 01100110 01110010 01100101 01100101 01100100 01101111 01101101 00100000 01000010 01100101 01100001 01100011 01101000 00100000 01101011 01101001 01101110 01100111 01100100 01101111 01101101";

        string[] binaryValues = binaryInput.Split(' ');
        StringBuilder textOutput = new StringBuilder();

        foreach (string binary in binaryValues)
        {
            int ascii = Convert.ToInt32(binary, 2);
            char character = (char)ascii;
            textOutput.Append(character);
        }

        Console.WriteLine("Decoded Text: " + textOutput.ToString());
    }
}
