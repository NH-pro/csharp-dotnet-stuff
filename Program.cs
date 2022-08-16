// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Make a string
string a = "This ";
string b = "is a ";
string c = "string!";
Console.Write(a);
Console.Write(b);
Console.WriteLine(c);


// Make a number
int n = 18;
Console.WriteLine(n);


// Make a boolean
bool check = true;
Console.WriteLine(check ? "Checked" : "Not checked"); // should output: Checked
Console.WriteLine(false ? "Checked" : "Not checked"); // should output: Checked


// Make an if/else block
if(check == true) {
    Console.WriteLine("Check is TRUE!"); // should output this condition
}
else {
    Console.WriteLine("Check is FALSE!");
} 


// Make a switch block
int x = 3;
switch(x) {
    case 1:
        Console.WriteLine("x is 1");
        break;
    case 2:
        Console.WriteLine("x is 2");
        break;
    case 3:
        Console.WriteLine("x is 3"); // should output this case
        break;
    default:
        Console.WriteLine("Somethin is wrong!");
        break;
}


// Make an array of strings
string[] stringArray = {"batman", "spiderman", "manman"};
Console.WriteLine(stringArray[0]); // should output: "batman"


// Make a for loop
for (int i = 0; i < 3; i++) {
    Console.WriteLine(i);  // should output: 0, 1, 2
}



Hotdog chicago = new Hotdog(); // create an instance of this class
Hotdog corndog = new Hotdog(); // create an instance of this class

Console.WriteLine(chicago.GetEnergy()); // 20
chicago.TakeBite();
Console.WriteLine(chicago.GetEnergy()); // 15

Console.WriteLine("Our corndog energy is:" + corndog.GetEnergy()); // 20


// Make a class
// public, private, internal, readonly, static...
public class Hotdog
{
    // fields
    // aka a variable that only belong to this object
    int energy; // default private

    string meat = "beef";
    float temperature;
    Color color;

    // constructor
    public Hotdog() {
        Console.WriteLine("constructed a hotdog object");
        energy = 20;
    }

    // method
    // void means it is going to work in the background and not return an integer
    public void TakeBite() {
        energy -= 5;
    }

    // getter
    public int GetEnergy() {
        return energy;
    }
}