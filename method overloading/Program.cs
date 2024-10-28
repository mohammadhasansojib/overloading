using System;

class Program{

    static int Addition(int x, int y){
        return x + y;
    }
    static double Addition(double x, double y){
        return x + y;
    }
    static string Addition(string x, string y){
        return x + " " + y;
    }
    static void Main(string[] args){
        
        int intAddition = Addition(10, 3);
        Console.WriteLine("int: " + intAddition);

        double doubleAddition = Addition(30.44, 32.33);
        Console.WriteLine("double: " + doubleAddition);

        string stringAddition = Addition("Hello", "World");
        Console.WriteLine("string: " + stringAddition);
    }
}