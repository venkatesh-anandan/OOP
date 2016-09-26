using System;
//Simple Example of Shadowing
//Method hiding will help in change in the functionality but shadowing is helpful where the type of the 
//object can be modified with functionalities as it is

class Class1
{
	public int i=0;
}

class Class2:Class1
{
	 public new string i=""; 
}



//New requirement invoice number should also accept Numeric. Now the requirement is changing the datatype. 
//Overriding with change the value not the type.
//To overcome this create a new class and inherit the SalesClass


class Program
{
	public static void Main()
	{
		Class1 obj1=new Class1();
		Class2 obj2=new Class2();
		obj1=new Class2();

		obj1.i=123;

		Console.WriteLine("Shadowing {0}",obj1.i);
		//obj2.i="123";

		//In Shadowing Parent class method is completely replaced by the child element.

		

	}
}