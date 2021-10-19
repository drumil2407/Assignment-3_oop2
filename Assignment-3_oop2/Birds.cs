using System;
using Assignment_3_oop2.Eggs;
//How we can add condition that will give 25% percent chance to broken in that given user input
//is it possible to use if because it gives error.
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
		// made a broken class object which is in egg class file
		BrokenEgg E = new BrokenEgg(0.2,Egg.Colors.brown);

		//layeggs method which returns egg ranges between 2 and 4 cm
		public override Egg[] LayEggs(int numEggs)
		{
            Console.WriteLine(E);
			Egg[] chickenEgg = new Egg[numEggs];
			int i=0;
			while(i < numEggs )
			{
				/*if (i == 0.2)
					{
						GetEgg();
					}
				*/
				chickenEgg[i] = new Egg(Rand.Next(2,4), Egg.Colors.brown);
				i++;
			}
			return chickenEgg;
		}
		//protected egg to retrieve broken eggg
		protected Egg GetEgg(double minSize, double maxSize, double brokenChance, Egg.Colors color) 
		{
			//Egg brokenegg = new BrokenEgg(Rand.Next(2,4),Egg.Colors.brown);
			//Egg brokenchickenegg = new Egg(2,4,0.2,Egg.Colors.brown);
			return GetEgg(2,4,0.2,Egg.Colors.brown);	
		}   
	}

	class Ostrich : Bird
	{
		//Egg E1 = new Egg(15, Egg.Colors.speckled);
		BrokenEgg E1 = new BrokenEgg(0.4, Egg.Colors.speckled);

		//layeggs method which returns egg ranges between 10 and 15 cm
		public override Egg[] LayEggs(int numEggs)
		{
            Console.WriteLine(E1);
			Egg[] ostrichEgg = new Egg[numEggs];
			int i = 0;
			while (i < numEggs)
			{
				
				/*if (i == 0.2)
					{
						GetEgg();
					}
				*/

				ostrichEgg[i] = new Egg(Rand.Next(10, 15), Egg.Colors.speckled);
				i++;
			}
			return ostrichEgg;
		}
		//protected egg to retrieve broken eggg

		protected Egg GetEgg(double minSize, double maxSize, double brokenChance, Egg.Colors color)
		{
			return GetEgg(2, 4, 0.25, Egg.Colors.speckled);
		}

	}
}

