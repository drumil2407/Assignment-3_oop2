using System;

namespace Assignment_3_oop2.Eggs
{
	
		class Egg
		{
			public enum Colors
			{
				speckled,
				brown
			}
			public static Random Rand = new Random(1);
		//public  double Size { get; private set; }
		   public double Size
		   {
				get { return Rand.Next(2, 15);}
				private set { }

		   }

		    public Colors Color { get; private set; }
			public Egg(double size, Colors color)
			{
				Size = size;
				Color = color;
			}
			
		    
			public override string ToString()
			{
				return $"A {Size:0.0}cm {Color} egg";
			}
			
		}
		/*
		class BrokenEgg : Egg
		{
			// TODO: Implement for Task 2
		}
		*/
}
