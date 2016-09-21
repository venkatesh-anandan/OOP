using System;

class clsProduct
{
	public int CalculateCost(int qty,int price)
	{
		return qty*price;
	}

	public int CalculateCost(int qty, int price,int discount)
	{
		return CalculateCost(qty,price)-discount;
	}
}

class Program
{
	public static void Main()
	{
		//Static Poloymorphishm
		Console.WriteLine("Method Overloading");

		clsProduct objProd=new clsProduct();
		Console.WriteLine("The Product Cost {0}",objProd.CalculateCost(10,10,20));
	}
}

