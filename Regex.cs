using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string name, email, password;

        // Get user input
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your email: ");
        email = Console.ReadLine();

        Console.Write("Enter your password: ");
        password = Console.ReadLine();

        // Validate user input using regular expressions
        Regex nameRegex = new Regex(@"^[a-zA-Z\s]+$");
        Regex emailRegex = new Regex(@"^[a-z]{3,5}[0-9]{2,4}[@gmail.com]");
        Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

        if (!nameRegex.IsMatch(name))
        {
            Console.WriteLine("Invalid name. Name should only contain letters and spaces.");
        }

        if (!emailRegex.IsMatch(email))
        {
            Console.WriteLine("Invalid email address.");
        }

        if (!passwordRegex.IsMatch(password))
        {
            Console.WriteLine("Invalid password. Password should be at least 4 characters long and contain at least one lowercase letter, one uppercase letter, one digit, and one special character.");
        }

        // If all input is valid, register the user
        if (nameRegex.IsMatch(name) && emailRegex.IsMatch(email) && passwordRegex.IsMatch(password))
        {
            Console.WriteLine("Registration successful!");
        }
    }
}