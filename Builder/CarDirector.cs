namespace netPatterns
{
	public class CarDirector: VehicleDirector
	{
		//the director determines the order in which th steps are to be executed
		//being executed by the builder
		public override IVehicle Build(VehicleBuilder builder){
			builder.BuildChassis();
			builder.BuildBody();
			builder.BuildPassengerArea();
			builder.BuildBoot();
			builder.BuildWindows();
			return builder.Vehicle;
		}
	}
}