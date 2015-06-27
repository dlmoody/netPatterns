namespace netPatterns
{
	public abstract class AbstractPartFactory
	{
		public abstract IBody CreateBody();
		public abstract IChassis CreateChassis();
		public abstract IGlassware CreateGlassware();
		
	}
}