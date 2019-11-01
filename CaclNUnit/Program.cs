using System;
using Autofac;

namespace CaclNUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Addition>().As<add>();
            builder.RegisterType<Subtration>().As<sub>();
            builder.RegisterType<Multiply>().As<mult>();
            builder.RegisterType<Divide>().As<div>();
            var container = builder.Build();

            container.Resolve<add>().addition();
            container.Resolve<sub>().subtration();
            container.Resolve<mult>().multiply();
            container.Resolve<div>().divide();

            Console.ReadLine();
        }
    }
}
