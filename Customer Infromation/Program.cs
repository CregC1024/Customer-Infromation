using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Enter Firstname:");

            // Create a string variable and get user input from the keyboard and store it in the variable
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string firstName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("FirstName is: " + firstName);
            Console.WriteLine("Enter LastName:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string lastName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("LastName is:" + lastName);
            
            Console.WriteLine("Enter Email:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string email = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Email is: " + email);
            Console.WriteLine("Enter PhoneNumber:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String phoneNumber = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("PhoneNumber is: " + phoneNumber);
            Console.WriteLine("Enter Address:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string address = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Address is: " + address);
            Console.WriteLine("Enter City:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string city = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("City is:" + city);
            Console.WriteLine("Enter state:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string state = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine(" Satet is: " + state);

        }
    }
}
