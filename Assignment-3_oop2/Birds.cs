using System;
using Assignment_3_oop2.Eggs;

namespace Assignment_3_oop2.Birds
{
    class Bird
    {
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
	}
	class Chicken : Bird
	{
		// TODO: Implement this class
	}

	class Ostrich : Bird
	{
		// TODO: Implement this class
	}
}

