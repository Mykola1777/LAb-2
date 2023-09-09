using System;

class User
{
    private string login;
    private string name;
    private string surname;
    private int age;
    private readonly DateTime date; 

    public User(string login, string name, string surname, int age, DateTime date)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.date = date;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine("Логiн: " + login);
        Console.WriteLine("Iм'я: " + name);
        Console.WriteLine("Прiзвище: " + surname);
        Console.WriteLine("Вiк: " + age);
        Console.WriteLine("Дата заповнення анкети: " + date.ToShortDateString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User("user123", "Олександр", "Петров", 25, DateTime.Now);

        user.ShowInfo();
    }
}
