using System;
using System.IO;


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
            
            using(TextWriter writer = File.CreateText("netPatterns.Log.txt")){
                Console.WriteLine("Writing");
                writer.WriteLine("Writing to the log");
            }
            
            Console.WriteLine("press any key to exit..... ");
            Console.ReadLine();
        }
    }
}
