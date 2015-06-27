
namespace netPatterns
{
	public class CarPartsFactory:AbstractPartFactory
	{
		public override IBody CreateBody()
		{
			return new CarBody();
		}
		public override IChassis CreateChassis()
		{
			return new CarChassis();
		}
		public override IGlassware CreateGlassware()
		{
			return new CarGlassware();
		}
	}
}