

namespace netPatterns
{
	public abstract class AbstractEngine : IEngine
	{
		private int _size;
		private bool _turbo;
		public AbstractEngine(int size, bool turbo)
		{
			_size = size;
			_turbo = turbo;
		}
		public virtual int Size
		{
			get
			{
				return _size;
			}
			
		}
		public virtual bool Turbo
		{
			get
			{
				return _turbo;
			}
		}
		public override string ToString()
		{
			return this.GetType().Name + " (" + _size + ")";
		}
	}
}