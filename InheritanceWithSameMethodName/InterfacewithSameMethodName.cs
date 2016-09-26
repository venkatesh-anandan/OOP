using System;

//Explicit Method Implementation

interface i1
{
	void Method1();
}

interface i2
{
	void Method1();
}

class class1:i1,i2
{
	void i1.Method1()
	{
		Console.WriteLine("Method1");
	}
	 void i2.Method1()
	{
		Console.WriteLine("Method2");
	}
	public void Method1()
	{
		Console.WriteLine("Default Method1");		
		
	}
	void Method2()
	{
		Console.WriteLine("Method2");
	}
}

class Program
{
	public static void Main()
	{
		i1 obj1=new class1();
		i2 obj2=new class1();
		obj1.Method1();
		obj2.Method1();
		class1 c1=new class1();
		c1.Method1();
	}
}