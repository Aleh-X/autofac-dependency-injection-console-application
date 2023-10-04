using ConsoleApp.Interfaces;

namespace ConsoleApp;

public class Car : ICar
{
    public IEngine Engine { get; }

    public Car(IEngine engine)
    {
        Engine = engine;
    }

    public void StartEngine()
    {
        var engineStarted = this.Engine.Start();

        if (engineStarted)
        {
            Console.WriteLine("Engine Started :)");

            return;
        }

        Console.WriteLine("Engine start failed :(");
    }
}

