// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Animais
{
    public static void Main(string[] args)
    {
        string x, y, z;
        Console.WriteLine("Digite as 3 características do animal: ");
        x = Console.ReadLine().ToUpper();
        y = Console.ReadLine().ToUpper();
       z = Console.ReadLine().ToUpper();
        
        if ( x == "VERTEBRADO" && y == "AVE" && z == "CARNIVORO") {
                Console.WriteLine("Águia");
} else if(x == "VERTEBRADO" && y == "AVE" && z == "ONIVORO") {
    Console.WriteLine("Pomba");
} 


else if (x == "VERTEBRADO" && y == "MAMIFERO" && z == "ONIVORO") {
    Console.WriteLine("Homem");
} else if ( x == "INVERTEBRADO" && y == "INSETO" && z == "HEMATOFAGO") {
    Console.WriteLine("Sanguessuga");
} else if(y == "INSETO" && z == "HERBIVORO") {
    Console.WriteLine("Lagarta");
} else if (x == "INVERTEBRADO" && y == "ANELIDEO" && y == "HEMATOFAGO") {
    Console.WriteLine("Sanguessuga");
} else if (y == "ANELIDEO" && z == "ONIVORO") {
    Console.WriteLine("Minhoca");
}
    }
}