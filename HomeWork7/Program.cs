using System;

namespace HomeWork7;

public class Program
{
    public static void Main()
    {
        int choice;

        do
        {
            ShowMenu();
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out choice) || choice < 1 || choice > 10)
            {
                Console.WriteLine("Please enter a valid menu number (1-10).");
                Pause();
                continue;
            }

            if (choice == 10)
                break;

            Console.Clear();

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("**** Count Digits ****");
                        Console.WriteLine($"Result: {DigitCounter.CountDigits(Input.ReadLong("Please enter an integer n: "))}");
                        break;

                    case 2:
                        Console.WriteLine("**** Prime Number ****");
                        Console.WriteLine(PrimeNumber.IsPrime(Input.ReadInt("Please enter an integer n: "))
                            ? "Prime"
                            : "Not prime");
                        break;

                    case 3:
                        Console.WriteLine("**** Sum of Digits ****");
                        Console.WriteLine($"Result: {DigitSum.DigitsSum(Input.ReadLong("Please enter an integer n: "))}");
                        break;

                    case 4:
                        Console.WriteLine("**** Palindrome Number ****");
                        Console.WriteLine(Palindrome.IsPalindrome(Input.ReadInt("Please enter an integer n: "))
                            ? "Palindrome"
                            : "Not palindrome");
                        break;

                    case 5:
                        {
                            Console.WriteLine("**** Greatest Common Divisor (GCD) ****");
                            long a = Input.ReadLong("Please enter a: ");
                            long b = Input.ReadLong("Please enter b: ");
                            Console.WriteLine($"GCD: {Gcd.FindGcd(a, b)}");
                            break;
                        }

                    case 6:
                        Console.WriteLine("**** Reverse Number ****");
                        Console.WriteLine($"Result: {NumberReverser.ReverseNumber(Input.ReadInt("Please enter an integer n: "))}");
                        break;

                    case 7:
                        Console.WriteLine("**** Decimal to Binary ****");
                        Console.WriteLine($"Binary: {BinaryConverter.ToBinary(Input.ReadInt("Please enter an integer n: "))}");
                        break;

                    case 8:
                        {
                            Console.WriteLine("**** String Permutations ****");
                            Console.Write("Please enter a string: ");
                            string text = Console.ReadLine() ?? string.Empty;
                            var permutations = PermutationGenerator.Permutations(text);
                            Console.WriteLine($"Count: {permutations.Count}");
                            Console.WriteLine(permutations.Count == 0
                                ? "No permutations were generated."
                                : string.Join(", ", permutations));
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("**** Duplicate Detection ****");
                            int[] numbers = Input.ReadIntArray("Please enter array numbers (space separated): ");
                            Console.WriteLine(DuplicateChecker.HasDuplicate(numbers)
                                ? "Duplicate exists."
                                : "No duplicate found.");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Pause();

        } while (true);

        Console.WriteLine("Goodbye!");
    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("========================= HomeWork 7 =========================");
        Console.WriteLine("1) Count digits          2) Prime number       3) Sum of digits");
        Console.WriteLine("4) Palindrome            5) GCD                6) Reverse number");
        Console.WriteLine("7) Decimal to binary     8) String permutations");
        Console.WriteLine("9) Duplicate detection   10) Exit");
        Console.Write("Choose an option: ");
    }

    private static void Pause()
    {
        Console.WriteLine();
        Console.Write("Press any key to return to the menu...");
        Console.ReadKey(intercept: true);
    }
}

public static class Input
{
    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.WriteLine("Please enter a valid 32-bit integer.");
        }
    }

    public static long ReadLong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (long.TryParse(Console.ReadLine(), out long value))
                return value;

            Console.WriteLine("Please enter a valid 64-bit integer.");
        }
    }

    public static int[] ReadIntArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string line = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Array cannot be empty. Please enter it again.");
                continue;
            }

            string[] parts = line.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[parts.Length];
            bool valid = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                return numbers;

            Console.WriteLine("Please enter valid integers separated by spaces.");
        }
    }
}
