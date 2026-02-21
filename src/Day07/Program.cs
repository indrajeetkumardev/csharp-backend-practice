using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
        Console.WriteLine("Age is valid");
    }

    static void Main()
    {
        try
        {
            CheckAge(16);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed");
        }
    }
}
