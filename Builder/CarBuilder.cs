
using System;

namespace netPatterns
{
	public class CarBuilder: VehicleBuilder
	{
		private AbstractCar carInProgress;
		
		// the builder implements each step but DOES NOT
		// define the order of the steps
		public CarBuilder(AbstractCar car){
			
			carInProgress = car;
		}
		public override IVehicle Vehicle
		{
			get
			{
				return null;
			}
		}
		public override void BuildBody()
		{
			Console.WriteLine("Building Car Body");
		}
		public override void BuildBoot()
		{
			Console.WriteLine("Builing Car Boot");
		}
		public override void BuildChassis()
		{
			Console.WriteLine("Builing Car Chassis");
		}
		public override void BuildPassengerArea()
		{
			Console.WriteLine("Builing Car Passenger Area");
		}
		public override void BuildWindows()
		{
			Console.WriteLine("Builing Car Windows");
		}
	}
}