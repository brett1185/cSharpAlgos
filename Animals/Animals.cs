public class Animal
{
    public string Name;
    protected string Diet;
    protected bool IsMammal;
    public Animal(string name, string diet, bool ismammal)
    {
        Name = name;
        Diet = diet;
        IsMammal = ismammal;
    }
        public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Mammal: {IsMammal}");
    }
}

