using System;


class Parent
{
	 internal Parent()
	{
		Console.WriteLine("Parent Class");
	}
}

class Child:Parent
{
	internal Child()
	{
		Console.WriteLine("Child Class");
	}
}

class Program
{
	public static void Main()
	{
		Child obj=new Child();
	}

}
