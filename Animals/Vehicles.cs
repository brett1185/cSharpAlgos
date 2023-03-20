class Vehicle {
   public string Name;
   public int Passengers;
   public string Color;
   public bool Engine;
   private int Mileage;


public Vehicle(string n, int p, string c, bool e){

    Name = n;
    Passengers = p;
    Color = c;
    Engine = e;
    Mileage= 0;
}

public Vehicle(string n, string c){
        Name = n;
        Passengers = 4;
        Color = c;
        Engine = true;
        Mileage = 0;

}

void ShowInfo(){
    Console.WriteLine($"This is a {Name}");
    Console.WriteLine($"It holds {Passengers} person/people");
    Console.WriteLine($"It is {Color}");
    Console.WriteLine($"Engine: {Engine}");
    Console.WriteLine($"It has gone {Mileage} miles");

}



void TripInfo (int TripDistance){
    Mileage += TripDistance;
    Console.WriteLine($"You have traveled {TripDistance} miles for a total of {Mileage}");
}
}