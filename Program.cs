using System;
using System.Linq;

namespace CC3_1N_PiñedaMarkAnthonyD_CSharpRampUp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1:
            // Conversion and Fantasy Story
            Console.Write("Enter weight in pounds (lbs): ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine($"Weight: {pounds} lbs | Converted: {kilograms} kg");

            Console.Write("\nEnter distance in miles (mi): ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine($"Distance: {miles} mi | Converted: {kilometers} km");

            Console.Write("\nEnter temperature in Fahrenheit (°F): ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature: {fahrenheit} °F | Converted: {celsius} °C");

            int[] studentAges = new int[10];
            int totalAges = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                studentAges[i] = Convert.ToInt32(Console.ReadLine());
                totalAges += studentAges[i];
            }
            double averageAge = (double)totalAges / 10;
            Console.WriteLine($"\nStudent Ages: {string.Join(", ", studentAges)} | Average Age: {averageAge:F2}");

            string heroName = "Lam Ang";
            string sidekickName = "Banggan";
            string weaponName = "Baliw-ag";
            string magicalItem = "Lusong";
            string specialAbility = "Panagpatay";

            string story = $@"
Once upon a time in the mystical land of Ilocos, there lived a young hero named {heroName}.
Accompanied by his loyal sidekick, {sidekickName}, they embarked on a quest to wield the legendary weapon, {weaponName},
and unlock the power of the enchanted {magicalItem}.

With the incredible {specialAbility} bestowed upon him, {heroName} faced mythical creatures and conquered
challenges to bring peace to the realm. Along the way, they discovered the ancient secret of the {magicalItem},
unleashing its power to save the kingdom from impending doom.

The tale of {heroName} and {sidekickName} echoed through the ages, a testament to bravery, friendship, and the
unyielding spirit of adventure in the magical land of Ilocos.
";
            Console.WriteLine(story);

            // Part 2:
            // Number Pattern Pattern
            Console.Write("\nEnter a positive integer for number pattern: ");
            int patternSize = Convert.ToInt32(Console.ReadLine());

            if (patternSize <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            else
            {
                Console.WriteLine("\nNumber Pattern 1:");
                for (int i = 1; i <= patternSize; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nNumber Pattern 2:");
                int sum = 0;
                for (int i = 1; i <= patternSize; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine($"\nFormula: {string.Join("+", Enumerable.Range(1, patternSize))}");
                Console.WriteLine($"Output: {sum}");

                Console.WriteLine("\nNumber Pattern 3:");
                for (int i = patternSize; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}

