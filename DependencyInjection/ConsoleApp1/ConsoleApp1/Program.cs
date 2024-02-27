using System;


public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Engine stopped.");
    }
}


public class Car
{
    private readonly Engine _engine;


    public Car(Engine engine)
    {
        _engine = engine;
    }

    public void StartCar()
    {
        _engine.Start();
        Console.WriteLine("Car started.");
    }

    public void StopCar()
    {
        _engine.Stop();
        Console.WriteLine("Car stopped.");
    }
}


class Program
{
    static void Main(string[] args)
    {
       
        Engine engine = new Engine();

       
        Car car = new Car(engine);

        
        car.StartCar();
        car.StopCar();
    }
}
