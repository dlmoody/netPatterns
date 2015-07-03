using System;

namespace netPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Running the Abstract Factory for a Car");
            var runner = new FactoryRunner();
            runner.Run(FactoryType.Car);
            
            Console.WriteLine("Running the Abstract Factory for a Van");
            runner.Run(FactoryType.Van);
            
            Console.WriteLine("Running Car builder");
            var builderRunner = new BuilderRunner();
            builderRunner.Run();
            
            Console.WriteLine("press any key to exit..... ");
            Console.ReadLine();
        }
    }
}
