using System;
namespace netPatterns
{
	public class BuilderRunner
	{
		public void Run()
		{
			
			AbstractCar car = new Saloon(new TurboEngine(1300));
			VehicleBuilder builder = new CarBuilder(car);
			VehicleDirector director = new CarDirector();
			IVehicle v = director.Build(builder);
			
			Console.WriteLine(v);
			
		}
	}
}