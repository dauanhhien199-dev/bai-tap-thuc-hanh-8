
using System;

interface IAnimal
{
    void Speak();
}

class Cho : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cho: Gau gau gau!");
    }
}

class Meo : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meo: Meo meo meo!");
    }
}

class Vit : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Vit: Quac quac quac!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal[] animals = new IAnimal[]
        {
            new Cho(),
            new Meo(),
            new Vit(),
            
        };

        Console.WriteLine(" HE THONG DONG VAT ");

        foreach (IAnimal animal in animals)
        {
            animal.Speak();
        }

        Console.ReadKey();
    }
}
