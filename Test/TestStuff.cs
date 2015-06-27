
using Xunit;


namespace netPatterns
{
	public class TestStuff
	{
		
		[Fact]
		public void CarPartsFactoryCreatesCarBodyParts()
		{
			var factory = new CarPartsFactory();
			
			var bodyPart = factory.CreateBody();
			
			Assert.IsType(typeof(CarBody), bodyPart);
			
		}
		
	}
}