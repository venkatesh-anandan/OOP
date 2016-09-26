using System;

/*

	The three important usage of Static keywords is

	1. To group un-related methods and properties and re-using the same.
	2. Since static is initialized and stored in memory only one to share the data across the projects/application
	3. To cache the object
	*/

class Country
{
	public string CountryCode{get;set;}
	public string CountryName{get;set;}
	public string ComputerName=Common.GetComputerName;
	public void Insert()
	{

	}
}
class Customer
{
	public string CustomerName{get;set;}
	public string CustomerCode{get;set;}
	private string ComputerName=Common.GetComputerName;
	public void Insert()
	{
		if(Common.IsEmpty(CustomerName)||Common.IsEmpty(CustomerCode))
		{
			Console.WriteLine("CustomerCode or Name cannot be empty");
		}
	}

}
public static class Common
{
	static Common()
	{

	}
	public static bool IsEmpty(string name)
	{
		if(string.IsNullOrEmpty(name))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public static string GetComputerName
	{
		get{return System.Environment.MachineName;}
	}

}
class Program
{
	public static void Main()
	{	
		Customer oCustomer=new Customer();
		oCustomer.Insert();


	}
}