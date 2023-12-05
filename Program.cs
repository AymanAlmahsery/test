namespace MyApplication;
class Program
{
    static void Main(string[] args)
    {
        /* Q1
        int[] numbers = new int[10];
        Console.WriteLine("Input the 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number-{i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum;
        double average;
        CalculateSumAndAverage(numbers, out sum, out average);
        Console.WriteLine($"The sum of 10 numbers is: {sum}");
        Console.WriteLine($"The Average is: {average:F6}");
        
        ****Q2
        Console.Write("Input number of terms: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"Number is: {i} and cube of {i} is: {cube}");
        }
        ******Q3
        *
        int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

        int[] result = GetYearsGreaterThan1950(years);

        Console.WriteLine("Years greater than 1950:");
        foreach (int year in result)
        {
            Console.WriteLine(year);
        }
        *****Q4
        Console.Write("Please Enter the age(Year) : ");
        int ageInYears = Convert.ToInt32(Console.ReadLine());
        int ageInDays = ConvertYearsToDays(ageInYears);
        Console.WriteLine($"Age in years: {ageInYears} - Age in days: {ageInDays}");
        ******Q5
        int totalLegs = CountTotalLegs(2, 3, 5);
        Console.WriteLine($"Total number of legs: {totalLegs}");
        *****Q6
        string result = Login("user", "123");
        Console.WriteLine(result); 
        *****Q7
        int baseNumber = 2;
        int exponent = 4;
        double result = CalculatePower(baseNumber, exponent);
        Console.WriteLine($"Result: {result}");
       *****Q8
        Console.Write("Enter a year between 1900 and 2024: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = IsLeapYear(year);
        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
        *****Q9
        Console.Write("Enter a number to check if it's prime: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
        *****Q10

        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        int wordCount = CountWords(sentence);
        Console.WriteLine($"The number of words in the sentence: {wordCount}");
        */
    }
    static int CountWords(string sentence)
    {
        int wordCount = 0;
        bool inWord = false;
        foreach (char c in sentence)
        {
            if (char.IsWhiteSpace(c) || char.IsPunctuation(c))
            {
                inWord = false;
            }
            else if (!inWord)
            {
                wordCount++;
                inWord = true;
            }
        }

        return wordCount;
    }
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsLeapYear(int year)
    {
        if (year >= 1900 && year <= 2024)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
        else
        {
            Console.WriteLine("Please enter a year within the range of 1900 to 2024.");
            return false;
        }

        static double CalculatePower(int baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
        static string Login(string username, string password)
        {
            if (username == "user" && password == "123")
            {
                return "Pass";
            }
            else
            {
                return "Failed";
            }
        }
        static int CountTotalLegs(int chickens, int cows, int pigs)
        {
            int totalChickensLegs = chickens * 2;
            int totalCowsLegs = cows * 4;
            int totalPigsLegs = pigs * 4;
            return totalChickensLegs + totalCowsLegs + totalPigsLegs;
        }

        static int ConvertYearsToDays(int ageInYears)
        {
            const int DaysInAYear = 365;
            return ageInYears * DaysInAYear;
        }
        static int[] GetYearsGreaterThan1950(int[] years)
        {
            List<int> filteredYears = new List<int>();

            foreach (int year in years)
            {
                if (year > 1950)
                {
                    filteredYears.Add(year);
                }
            }

            return filteredYears.ToArray();
        }
        static void CalculateSumAndAverage(int[] numbers, out int sum, out double average)
        {
            sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            average = (double)sum / numbers.Length;
        }
    }
}