using System;

namespace Konvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Избери операция:");
                Console.WriteLine("1. Двоична в десетична:");
                Console.WriteLine("2. Десетична в двоична:");
                Console.WriteLine("3. Дванайсетична в двоична:");
                Console.WriteLine("4. Изход");
                Console.Write("Въведи число: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Грешен избор. Моля въведи правилно число.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Въведи двоично число: ");
                        string binaryInput = Console.ReadLine();
                        int decimalResult = ConvertBinaryToDecimal(binaryInput);
                        Console.WriteLine($"Десетично : {decimalResult}");
                        break;

                    case 2:
                        Console.Write("Въведи десетично число: ");
                        if (int.TryParse(Console.ReadLine(), out int decimalInput))
                        {
                            string binaryResult = ConvertDecimalToBinary(decimalInput);
                            Console.WriteLine($"Двоично: {binaryResult}");
                        }
                        else
                        {
                            Console.WriteLine("Невалидно десетично число.");
                        }
                        break;

                    case 3:
                        Console.Write("Въведи дванайсетично число: ");
                        string duodecimalInput = Console.ReadLine();
                        int duodecimalResult = ConvertDuodecimalToDecimal(duodecimalInput);
                        Console.WriteLine($"Десетично: {duodecimalResult}");
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Невалиден избор. Моля въведи валидно число.");
                        break;
                }
            }
        }

        static int ConvertBinaryToDecimal(string binary)
        {
            int decimalNumber = 0;
            int binaryLength = binary.Length;

            for (int i = 0; i < binaryLength; i++)
            {
                int digit = binary[i] - '0';
                decimalNumber += digit * (int)Math.Pow(2, binaryLength - 1 - i);
            }

            return decimalNumber;
        }

        static string ConvertDecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        static int ConvertDuodecimalToDecimal(string duodecimal)
        {
            string duodecimalCharacters = "0123456789AB"; 

            int decimalNumber = 0;
            int duodecimalLength = duodecimal.Length;

            for (int i = 0; i < duodecimalLength; i++)
            {
                int digit = duodecimalCharacters.IndexOf(duodecimal[i]);
                decimalNumber += digit * (int)Math.Pow(12, duodecimalLength - 1 - i);
            }

            return decimalNumber;
        }
    }
}
