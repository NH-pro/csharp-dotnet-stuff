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


// Make a class
