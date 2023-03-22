class Dog : Animal{
 
public string FurColor;
string Breed;
 public Dog(string fc, string b) : base ("Dog", "Carnivorous", true){
    FurColor = fc;
    Breed = b;
 }




    void Bark(){
        Console.WriteLine("Bark! Bark!");
    }

    void Fetch(string Item){
        Console.WriteLine($"{Name} hurries to fetch the {Item}!");
    }
      public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Breed: {Breed}");
        Console.WriteLine($"Fur Color: {FurColor}");
    }
}

