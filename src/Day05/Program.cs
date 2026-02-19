using System;

class Employee
{
    private int salary; // Encapsulation

    public void SetSalary(int amount)
    {
        salary = amount;
    }

    public int GetSalary()
    {
        return salary;
    }
}

class Developer : Employee // Inheritance
{
    public void ShowRole()
    {
        Console.WriteLine("Role: Backend Developer");
    }
}

class Program
{
    static void Main()
    {
        Developer dev = new Developer();
        dev.SetSalary(50000);

        dev.ShowRole();
        Console.WriteLine("Salary: " + dev.GetSalary());
    }
}
