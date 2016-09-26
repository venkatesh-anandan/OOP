using System;
public partial class  class1
{
	internal void m1()
	{
		Console.WriteLine("Method 1");
	}
	  partial void ToImplement()
	  {
	  	Console.WriteLine("Implemented");
	  }

}
class Program
{
	public static void Main()
	{
		class1 c=new class1();
		c.m1();
		c.m2();
		
	}
}

partial class class1
{
	internal void m2()
	{
		Console.WriteLine("Method 2");
	}
	partial void ToImplement()
	{
		Console.WriteLine("Implemented");
	}
}