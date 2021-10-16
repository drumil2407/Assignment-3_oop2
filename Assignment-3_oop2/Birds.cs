using System;
using Assignment_3_oop2.Eggs;

namespace Assignment_3_oop2.Birds
{
    abstract class Bird
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

		Egg E = new Egg(4,Egg.Colors.brown);
		
		

		public override Egg[] LayEggs(int numEggs)
		{

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(E);
				

			}
			return new Egg[0];
		}

		
		
        

	}

	class Ostrich : Bird
	{
		// TODO: Implement this class

		Egg E1 = new Egg(15, Egg.Colors.speckled);


		public override Egg[] LayEggs(int numEggs)
		{

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(E1);

			}
			return new Egg[0];
		}
	}
}

