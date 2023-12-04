//Correct the syntax error:

int[] ARR = { 1, 7, 9, 45 };
string[] arr2 = { "Str", "alex", "moh" };
string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
/*What the index of "Banana","Tomato"?
String [ ] fruits =["Tomato", "Banana", "Watermelon"]*/
string anser = " 1 , 0";
/*Create an multiple arrays that represents your:
Favorite Food(5 item)
Favorite Sport(3 item)
Favorite Movie(4 item)
Then, print each array using foreach, and Loop Through an Array*/
string[] fFoods = { "Pizza", "Vegetables", "Burgers", "Fish", "Chicken" };
string[] fSports = { "Fotbool", "Basketball", "Tennis" };
string[] fMovies = { "The Shawshank Redemption", "Inception", "The Dark Knight", "Pulp Fiction" };
Console.WriteLine("Favorite Foods:");
foreach (string food in fFoods)
{
    Console.WriteLine(food);
}
Console.WriteLine("Favorite Sports:");
foreach (string sport1 in fSports)
{
    Console.WriteLine(sport1);
}
Console.WriteLine("Favorite Movies:");
foreach (string movie in fMovies)
{
    Console.WriteLine(movie);
}
/*Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
Expected Output:
Input three numbers separated by comma: 5,10,15
The sum of three numbers: 30.*/
Console.Write("Input three numbers separated by comma: ");
string input = Console.ReadLine();
string[] numbers = input.Split(',');
int sum = 0;
foreach (string num in numbers)
{
    sum += int.Parse(num.Trim());
}
Console.WriteLine($"The sum of three numbers: {sum}");
/*Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
Test Data
The odd numbers are1 3 5 7 9 11 13 15 17 19……
The Sum of odd Numbers is: …...*/
int sum = 0;
Console.Write("The odd numbers are: ");
for (int i = 1; i <= 100 ; i += 2)
{
    Console.Write(i + " ");
    sum += i;
}
Console.WriteLine("\nThe Sum of odd Numbers is: " + sum);
/*Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
The pattern like:
   *
  **
 ***
*/
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("*");
    }

    /*    Console.WriteLine();
        Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
    The pattern like :
    1
   2 3
  4 5 6
 7 8 9 10
    */
    int rows = 4; 
    int number = 1;

    for (int i = 1; i <= rows; i++)
    {   for (int j = 1; j <= rows - i; j++)
        {   Console.Write(" ");
        }
        for (int k = 1; k <= i; k++)
        {   Console.Write(number + " ");
            number++;
        }

        Console.WriteLine();
    }