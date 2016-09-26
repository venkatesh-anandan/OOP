using System;

 class clsProduct
{
	public virtual int CalculateCost(int qty,int price)
	{


		return (qty*price)-10;
	}

	public int CalculateCost(int qty, int price,int discount)
	{
		return (CalculateCost(qty,price)-discount);
	}
}
class clsProductVer2:clsProduct
{
	public  override  int CalculateCost(int qty,int price)
	{
		Console.WriteLine("Ver2 Called");
		return (qty*price)-10;
	}

}

class clsProductVer3:clsProductVer2
{
	public override int CalculateCost(int qty,int price)
	{
		return 0;
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
		clsProductVer2 ver2=new clsProductVer2();
		Console.WriteLine("Cost ver2 {0}",	ver2.CalculateCost(20,20));


	}
}

