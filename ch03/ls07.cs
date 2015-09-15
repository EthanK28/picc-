using System;

class Select {
	static void Main() {
		int a;
		for (a = 5; a <= 8; a++) {
			Console.Write(a + "/3= " + a/3);
			
			switch (a % 3)
			{
				case 1:
					Console.WriteLine(": 나머지는 1입니다");
					break;
				case 2:
					Console.WriteLine(": 나머지는 2입니다.");
					break;
				default:
					Console.WriteLine(":나머지는 0입니다");
					break;
				
					
			}
		}
	}
}
