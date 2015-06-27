
using System;

namespace netPatterns
{
	public class FactoryRunner
	{
		
		public void Run(FactoryType type)
		{
			AbstractPartFactory factory = GetFactory(type);
			
			IBody body = factory.CreateBody();
			IChassis chassis = factory.CreateChassis();
			IGlassware glass = factory.CreateGlassware();
			
			Console.WriteLine("-----------------------------");
			Console.WriteLine("body parts created: " + body.BodyParts);
			Console.WriteLine("chassis parts created: " + chassis.ChassisParts);
			Console.WriteLine("glassware parts created: " + glass.GlasswareParts);
			Console.WriteLine("-----------------------------");
			
			
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