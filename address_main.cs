using System;

class Address
{
    private int index;
    private string country;
    private string city;
    private string street;
    private int house;
    private int apartment;

    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public int House
    {
        get { return house; }
        set { house = value; }
    }

    public int Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();

        address.Index = 79000;
        address.Country = "Україна";
        address.City = "Львів";
        address.Street = "Свободи";
        address.House = 12;
        address.Apartment = 34;

        Console.WriteLine("Адреса:");
        Console.WriteLine("Індекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Місто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);
    }
}
