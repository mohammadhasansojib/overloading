using System;

class Car{

    public string model;
    public string color;
    private int release_year;

    public int Release_year{
        get{return release_year;}
        set{release_year = value;}
    }
    public Car(){
        model = "xyz";
        color = "default color";
        Release_year = 0000;
    }
    public Car(string car_model){
        model = car_model;
        color = "default color";
        Release_year = 0000;
    }
    public Car(string car_model, string car_color){
        model = car_model;
        color = car_color;
        Release_year = 0000;
    }
    public Car(string car_model, string car_color, int car_release_year){
        model = car_model;
        color = car_color;
        Release_year = car_release_year;
    }

    public void Display(){
        Console.WriteLine("model: " + model);
        Console.WriteLine("color: " + color);
        Console.WriteLine("release year: " + release_year);
    }
}


class Program{
    static void Main(string[] args){
        
        Car Tesla = new Car();
        Tesla.Display();

        Console.WriteLine();

        Car para1 = new Car("Model S");
        para1.Display();

        Console.WriteLine();

        Car para2 = new Car("Model S", "Red");
        para2.Display();

        Console.WriteLine();

        Car para3 = new Car("Model S", "Red", 2022);
        para3.Display();

    }
}