using System;

class Number {
	static void Main() {
		int [ , ] a = {
			{10, 20},
			{30, 40},
			{50, 60}
		};
		
		a[1, 1] = 0;
		
		Console.WriteLine("a[0,0]="+a[0,0] + '\t' + "a[0,1]=" + a[0,1]);
		Console.WriteLine("a[1,0]="+a[1,0] + '\t' + "a[1,1]=" + a[1,1]);
		
	}
}