using System;

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double UahToUsd(double uah)
    {
        return uah / usd;
    }

    public double UsdToUah(double usd)
    {
        return usd * this.usd;
    }

    public double UahToEur(double uah)
    {
        return uah / eur;
    }

    public double EurToUah(double eur)
    {
        return eur * this.eur;
    }

    public double UahToPln(double uah)
    {
        return uah / pln;
    }

    public double PlnToUah(double pln)
    {
        return pln * this.pln;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(37.5, 39.2, 8.7);

        Console.WriteLine("1000 гривень у доларах: " + converter.UahToUsd(1000));
        Console.WriteLine("500 доларів у гривнях: " + converter.UsdToUah(500));
        Console.WriteLine("2000 гривень у євро: " + converter.UahToEur(2000));
        Console.WriteLine("300 євро у гривнях: " + converter.EurToUah(300));
        Console.WriteLine("1500 гривень у злотих: " + converter.UahToPln(1500));
        Console.WriteLine("400 злотих у гривнях: " + converter.PlnToUah(400));
    }
}
