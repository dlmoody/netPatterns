
using System;

namespace netPatterns
{
	public class VanBuilder: VehicleBuilder
	{
		private AbstractVan vanInProgress;
		
		// the builder implements each step but DOES NOT
		// define the order of the steps
		public VanBuilder(AbstractVan van){
			
			vanInProgress = van;
		}
		public override IVehicle Vehicle
		{
			get
			{
				return vanInProgress;
			}
		}
		public override void BuildBody()
		{
			
			Console.WriteLine("Building Van Body");
		}
		
		public override void BuildChassis()
		{
			Console.WriteLine("Builing Van Chassis");
		}
		public override void BuildReinforcedStorageArea()
		{
			Console.WriteLine("Builing Van Passenger Area");
		}
		public override void BuildWindows()
		{
			Console.WriteLine("Builing Van Windows");
		}
	}
}