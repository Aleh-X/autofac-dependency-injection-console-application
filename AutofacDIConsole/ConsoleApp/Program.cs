using Autofac;
using ConsoleApp;
using ConsoleApp.Interfaces;

var containerBuilder = new ContainerBuilder();

containerBuilder.RegisterType<Car>().As<ICar>();
containerBuilder.RegisterType<Engine>().As<IEngine>();

var container = containerBuilder.Build();

using (var scope = container.BeginLifetimeScope())
{
    var car = scope.Resolve<ICar>();

    car.StartEngine();
}

Console.ReadKey();
