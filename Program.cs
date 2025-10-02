using System.Text;
using System.Threading.Channels;
using System.Xml;

namespace Assignment_1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 1. Write a program that reads two numbers from the user and prints their sum, difference, roduct, and quotient(Arithmetic Operators).
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum: {num1 + num2}");
            //Console.WriteLine($"Difference: {num1 - num2}");
            //Console.WriteLine($"Product: {num1 * num2}");
            //Console.WriteLine($"Quotient: {num1 / num2}");

            // 2. Create a program that compares two numbers and prints whether they are equal or not (Relational Operators).
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 == num2)
            //{

            //    Console.Write("The numbers are equal.");
            //}
            //else
            //{
            //    Console.Write("The numbers are not equal.");
            //}

            // 3. Write code using Logical Operators to check if the user’s age is greater than 18 and salary is greater than 5000.
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Enter your salary: ");
            //int salary = int.Parse(Console.ReadLine());
            //if (age > 18 && salary > 5000)
            //{
            //    Console.Write("You are eligible.");
            //}
            //else
            //{
            //    Console.Write("You are not eligible.");
            //}
            // 4. Demonstrate the difference between `x = y;` and `x += y;` with examples (Assignment Operators).
            //int x = 10;
            //int y = 5;
            //x = y; // x = 5
            //Console.WriteLine($"After x = y : x = {x}");
            //x += y; // x = x + y = 5 + 5 = 10
            //Console.WriteLine($"After x += y : x = {x}");

            // 5. Write a program that demonstrates the use of Unary Operators (++ and --) on a variable.
            //int a = 10;
            //Console.WriteLine($"Initial value of a: {a}"); // 10
            //Console.WriteLine($"After a++ : {a++}"); // 10 (but a becomes 11 after this line)
            //Console.WriteLine($"After ++a : {++a}"); // 12 (a was 11, now becomes 12 before printing)
            //Console.WriteLine($"After a-- : {a--}"); // 12 (but a becomes 11 after this line)
            //Console.WriteLine($"After --a : {--a}"); // 10 (a was 11, now becomes 10 before printing)

            // 6. Use the Ternary Operator to check if a number is even or odd.
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //string result = (num % 2 == 0) ? "Even" : "Odd";
            //Console.WriteLine($"The number is {result}");

            // 7. Demonstrate the Null-Coalescing Operator (`??` and `??=`) on a nullable string variable.
            //string name = null; // Nullable string
            //// Using ?? operator to provide a default value if name is null
            //string displayName = name ?? "Guest";
            //Console.WriteLine($"Hello, {displayName}"); // Hello, Guest

            // 8. Write a program that shows the difference between string concatenation using `+` and string interpolation.
            //string firstName = "Omar";
            //string lastName = "Saber";
            //string fullNameConcat = firstName + " " + lastName; // Using + operator
            //Console.WriteLine("Full Name (Concatenation): " + fullNameConcat);
            //string fullNameInterpol = $"{firstName} {lastName}";
            //Console.WriteLine($"Full Name (Interpolation): {fullNameInterpol}"); // Using string interpolation

            // 9. Write a program that prints the current date in the format `dd/MM/yyyy` using string formatting.
            //DateTime currentDate = DateTime.Now;
            //Console.WriteLine($"Current Date: {currentDate:dd/MM/yyyy}");

            // 10. Show an example proving that strings are immutable (use `Replace` and check whether the reference changes or not).
            //string s = "Omar, Saber!";
            //Console.WriteLine($"Original String: {s}");
            //string afterReplace = s.Replace("Saber", "Saboora");
            //Console.WriteLine($"Modified String: {afterReplace}");
            //Console.WriteLine($"Are references equal? {ReferenceEquals(s, afterReplace)}"); // Should be False

            // 11. Write code using StringBuilder to add 3 different sentences and then remove one of them.
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Omar ");
            //sb.Append("Saber ");
            //sb.Append("Saboora");
            //Console.WriteLine($"Before Removal: {sb.ToString()}");
            //sb.Remove(5, 5); // Remove "Saber" (starting at index 5, length 5)
            //Console.WriteLine($"After Removal: {sb.ToString()}");

            // 12. Write a program that reads a student’s grade and prints 'Pass' if >= 50, otherwise 'Fail'.
            //Console.Write("Enter your grade: ");
            //int grade = int.Parse(Console.ReadLine());
            //string result = (grade >= 50) ? "Pass" : "Fail";
            //Console.WriteLine(result);

            // 13. Create a switch statement that checks a number from 1 to 3 and prints 'One', 'Two', or 'Three'.
            //Console.Write("Enter a number (1-3): ");
            //int number = int.Parse(Console.ReadLine());
            //switch (number)
            //{

            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    default:
            //        Console.WriteLine("Number out of range");
            //        break;
            //}

            // 14. Rewrite the previous example using a switch expression .
            //Console.Write("Enter a number (1-3): ");
            //int number = int.Parse(Console.ReadLine());
            //string result = number switch
            //{
            //    1 => "One",
            //    2 => "Two",
            //    3 => "Three",
            //    _ => "Number out of range"
            //};
            //Console.WriteLine(result);

            // 15. Write a for loop that prints numbers from 1 to 10.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            // 16. Write a foreach loop that prints the names of 5 students stored in an array.
            //string[] studente = { "omar", "khodary", "hossam", "ahmed", "karim" };
            //foreach (var item in studente)
            //{
            //    Console.Write($"{item} ");
            //}

            // 17. Write a while loop that keeps asking the user to enter numbers and sums them until the user enters 0.
            //int sum = 0;
            //Console.WriteLine("Enter any number: ");
            //while (true)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    if (x == 0)
            //    {
            //        break;
            //    }
            //    sum += x;
            //}
            //Console.WriteLine($"Sum = {sum}");

            // 18. Write a do-while loop that asks the user to enter a password and repeats until the user enters '1234'.
            //string password;
            //do
            //{
            //    Console.Write("Enter your password: ");
            //    password = Console.ReadLine();
            //} while (password != "1234");
            //Console.WriteLine("Access Granted.");

            // 19. Create a 2D array (3x3), fill it with numbers 1–9, and print it.
            //int[,] matrix = new int[3, 3];
            //int value = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrix[i, j] = value++;
            //    }
            //}
            //Console.WriteLine("2D Array (3x3):");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // 20. Write a program that demonstrates the difference between shallow copy and deep copy on an integer array.



        }
    }
}
