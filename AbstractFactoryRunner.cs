
namespace netPatterns
{
	public class AbstractFactoryRunner
	{
		
		public void Run(FactoryType type)
		{
			AbstractPartFactory factory = GetFactory(type);
			
			IBody body = factory.CreateBody();
			IChassis chassis = factory.CreateChassis();
			IGlassware glass = factory.CreateGlassware();
			
			System.Console.WriteLine("body parts created: " + body.BodyParts);
			System.Console.WriteLine("chassis parts created: " + chassis.ChassisParts);
			System.Console.WriteLine("glassware parts created: " + glass.GlasswareParts);
			System.Console.Read();
			
		}
		private AbstractPartFactory GetFactory(FactoryType type)
		{
			if(type == FactoryType.Car )
			{
				return new CarPartsFactory();
			}
			else
			{
				return new VanPartsFactory();
			}
			
		}
	}
	
	public enum FactoryType{
		Car, Van
	}
}