// Random rand = new Random();


// for (int i =1; i <= 255; i ++)
// {
// Console.WriteLine(i);
// }

// int sum = 0;
// for(int i = 1; i <=5; i ++){
    
//     int num = rand.Next(10, 20);
//     Console.WriteLine(num);
//     sum += num;
//     if( i == 5){
//         Console.WriteLine(sum);
//     }
// }

// for( int i = 1; i<= 100; i++){
//     if(i % 3 == 0 && i % 5 ==0 ){
//         Console.WriteLine("fizzbuzz");
//     }
//     else if(i % 5 == 0){
//         Console.WriteLine("buzz");
//     }
//     else if (i % 3 == 0 ){
//         Console.WriteLine("fizz");
//     }
//     else {
//         Console.WriteLine(i);
//     }

// }


int[] numbers = new int[10];

for (int i = 0; i <numbers.Length; i++){
    Console.WriteLine(numbers[i]);
}

bool[] boolean = new bool[10];
bool value = true;

for(int i = 0; i< boolean.Length; i++){
    boolean[i]= value;
    value = !value;
    Console.WriteLine(boolean[i]);
}

List<string> flavors = new List<string>();
List<string> names = new List<string>();

names.Add("mike");
names.Add("tom");
names.Add("susan");
names.Add("brad");

flavors.Add("vanilla");
flavors.Add("chocolate");
flavors.Add("mint chocolate chip");
flavors.Add("strawberry");

Dictionary<string, string> info = new Dictionary<string,string>();

for( int i = 0; i < names.Count; i++){
    info.Add(names[i], flavors[i]);
}

foreach(KeyValuePair<string, string> entry in info){
    Console.WriteLine(entry);
}
    

