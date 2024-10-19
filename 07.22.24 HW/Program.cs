using System;
using System.Collections.Generic;


//Task 1
public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public string Habitat { get; set; }

    public Animal(string name, string species, string habitat)
    {
        Name = name;
        Species = species;
        Habitat = habitat;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} is a {Species} living in {Habitat}.");
    }
}

public class Tiger : Animal
{
    public Tiger(string name) : base(name, "Tiger", "Forest") { }
}

public class Crocodile : Animal
{
    public Crocodile(string name) : base(name, "Crocodile", "Swamp") { }
}

public class Kangaroo : Animal
{
    public Kangaroo(string name) : base(name, "Kangaroo", "Grassland") { }
}


//Task 2
public abstract class Worker
{
    public string Name { get; set; }

    public Worker(string name)
    {
        Name = name;
    }

    public abstract void Print();
}

public class President : Worker
{
    public President(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"President: {Name}");
    }
}

public class Security : Worker
{
    public Security(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Security: {Name}");
    }
}

public class Manager : Worker
{
    public Manager(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Manager: {Name}");
    }
}

public class Engineer : Worker
{
    public Engineer(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Engineer: {Name}");
    }
}


//Task 3
public abstract class Vehicle
{
    public string Model { get; set; }

    public Vehicle(string model)
    {
        Model = model;
    }

    public abstract void Display();
}

public class Plane : Vehicle
{
    public int Wingspan { get; set; }

    public Plane(string model, int wingspan) : base(model)
    {
        Wingspan = wingspan;
    }

    public override void Display()
    {
        Console.WriteLine($"Plane Model: {Model}, Wingspan: {Wingspan} meters");
    }
}

public class Car : Vehicle
{
    public int Horsepower { get; set; }

    public Car(string model, int horsepower) : base(model)
    {
        Horsepower = horsepower;
    }

    public override void Display()
    {
        Console.WriteLine($"Car Model: {Model}, Horsepower: {Horsepower}");
    }
}


// Task 4
public abstract class Equation
{
    public abstract void FindRoots();
}

public class LinearEquation : Equation
{
    private double a, b;

    public LinearEquation(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override void FindRoots()
    {
        if (a != 0)
        {
            double root = -b / a;
            Console.WriteLine($"Root of the linear equation: {root}");
        }
        else
        {
            Console.WriteLine("No roots, 'a' cannot be 0.");
        }
    }
}

public class QuadraticEquation : Equation
{
    private double a, b, c;

    public QuadraticEquation(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override void FindRoots()
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Roots of the quadratic equation: {root1} and {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Root of the quadratic equation: {root}");
        }
        else
        {
            Console.WriteLine("No real roots.");
        }
    }
}


//Task 5
public abstract class TransportVehicle
{
    public abstract void Input();
    public abstract void Output();
    public abstract double FuelConsumption();
    public abstract double GetCost();
    public abstract void SetCost(double cost);
    public abstract double LoadCapacity();
    public abstract int PassengerCapacity();
}

public class TransportCar : TransportVehicle
{
    private double cost;

    public override void Input()
    {

    }

    public override void Output()
    {
        Console.WriteLine("Car details");
    }

    public override double FuelConsumption()
    {
        return 7.5;
    }

    public override double GetCost()
    {
        return cost;
    }

    public override void SetCost(double cost)
    {
        this.cost = cost;
    }

    public override double LoadCapacity()
    {
        return 500;
    }

    public override int PassengerCapacity()
    {
        return 5;
    }
}

public class Truck : TransportVehicle
{
    private double cost;

    public override void Input()
    {
    }

    public override void Output()
    {
        Console.WriteLine("Truck details");
    }

    public override double FuelConsumption()
    {
        return 15;
    }

    public override double GetCost()
    {
        return cost;
    }

    public override void SetCost(double cost)
    {
        this.cost = cost;
    }

    public override double LoadCapacity()
    {
        return 15000;
    }

    public override int PassengerCapacity()
    {
        return 3;
    }
}


// Task 6
public abstract class GeometricFigure
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Triangle : GeometricFigure
{
    private double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Area()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public override double Perimeter()
    {
        return a + b + c;
    }
}

public class Square : GeometricFigure
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return 4 * side;
    }
}

public class CompositeFigure
{
    private List<GeometricFigure> figures;

    public CompositeFigure()
    {
        figures = new List<GeometricFigure>();
    }

    public void AddFigure(GeometricFigure figure)
    {
        figures.Add(figure);
    }

    public double TotalArea()
    {
        double area = 0;
        foreach (var figure in figures)
        {
            area += figure.Area();
        }
        return area;
    }
}


class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Tiger tiger = new Tiger("Tigger");
        Crocodile crocodile = new Crocodile("Croc");
        Kangaroo kangaroo = new Kangaroo("Joey");

        tiger.PrintInfo();
        crocodile.PrintInfo();
        kangaroo.PrintInfo();


        //Task 2
        Worker[] workers = {
            new President("Alice"),
            new Security("Bob"),
            new Manager("Charlie"),
            new Engineer("Dave")
        };

        foreach (var worker in workers)
        {
            worker.Print();
        }


        //Task 3
        Vehicle plane = new Plane("Boeing 747", 60);
        Vehicle car = new Car("Tesla Model S", 670);

        plane.Display();
        car.Display();


        //Task 4
        Equation linear = new LinearEquation(2, 3);
        Equation quadratic = new QuadraticEquation(1, -3, 2);

        linear.FindRoots();
        quadratic.FindRoots();


        //Task 5
        TransportVehicle[] vehicles = new TransportVehicle[]
        {
            new TransportCar(),
            new Truck()
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Output();
        }


        //Task 6
        CompositeFigure compositeFigure = new CompositeFigure();
        compositeFigure.AddFigure(new Triangle(3, 4, 5));
        compositeFigure.AddFigure(new Square(4));
        Console.WriteLine($"Total area of composite figure: {compositeFigure.TotalArea()}");
    }
}
