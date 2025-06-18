using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Shape Area Calculator!");
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int option))
            {
                if (option == 1)
                {
                    CalculateCircleArea();
                }
                else if (option == 2)
                {
                    CalculateRectangleArea();
                }
                else if (option == 3)
                {
                    CalculateSquareArea();
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        Console.WriteLine("Thank you for using the Shape Area Calculator. Goodbye!");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease choose a shape to calculate the area:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Square");
        Console.WriteLine("4. Exit");
        Console.Write("Enter the number of your choice: ");
    }

    static double GetPositiveDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }

    static void CalculateCircleArea()
    {
        double radius = GetPositiveDouble("Enter the radius of the circle: ");
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"The area of the circle is {area:F2} square units.");
    }

    static void CalculateRectangleArea()
    {
        double length = GetPositiveDouble("Enter the length of the rectangle: ");
        double width = GetPositiveDouble("Enter the width of the rectangle: ");
        double area = length * width;
        Console.WriteLine($"The area of the rectangle is {area:F2} square units.");
    }

    static void CalculateSquareArea()
    {
        double side = GetPositiveDouble("Enter the side length of the square: ");
        double area = side * side;
        Console.WriteLine($"The area of the square is {area:F2} square units.");
    }
}