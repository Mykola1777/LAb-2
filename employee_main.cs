using System;

class Employee
{
    private string surname;
    private string name;
    private string position;

    public Employee(string surname, string name)
    {
        this.surname = surname;
        this.name = name;
    }

    public void CalculateSalaryAndTax(int experience)
    {
        double salary = 0;

        double tax = 0;

        double taxRate = 0.18;

        if (experience < 1)
        {
            position = "Стажер";
            salary = 5000;
        }
        else if (experience >= 1 && experience < 3)
        {
            position = "Молодший спеціаліст";
            salary = 10000;
        }
        else if (experience >= 3 && experience < 5)
        {
            position = "Спеціаліст";
            salary = 15000;
        }
        else if (experience >= 5 && experience < 10)
        {
            position = "Старший спеціаліст";
            salary = 20000;
        }
        else if (experience >= 10)
        {
            position = "Експерт";
            salary = 25000;
        }

        tax = salary * taxRate;

        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine("Прiзвище: " + surname);
        Console.WriteLine("Iм'я: " + name);
        Console.WriteLine("Посада: " + position);
        Console.WriteLine("Оклад: " + salary);
        Console.WriteLine("Податковий збiр: " + tax);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Іванов", "Іван");

        employee.CalculateSalaryAndTax(4);
    }
}
