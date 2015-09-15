using System;

class Enumsample
{
	enum Animal { mouse, cat, bird, dog=100, koala, pig=200, lion };
	static void Main() {
		Animal a;
		a = Animal.dog;

		Console.WriteLine(Animal.cat);
		Console.WriteLine((int)Animal.dog);
		Console.WriteLine((int)Animal.lion);
		Console.WriteLine(a);
	}
}
