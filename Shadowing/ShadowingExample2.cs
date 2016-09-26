using System;
//Simple Example of Shadowing
//Method hiding will help in change in the functionality but shadowing is helpful where the type of the 
//object can be modified with functionalities as it is


class Asset
{
	public int AssetId{get;set;}	
}

//New requirement invoice number should also accept Numeric. Now the requirement is changing the datatype. 
//Overriding with change the value not the type.
//To overcome this create a new class and inherit the SalesClass

class AssetVer2:Asset
{
	public   string AssetId{get;set;}
}

class Program
{
	public static void Main()
	{
		Asset objAsset=new Asset();
		objAsset.AssetId=10;
		AssetVer2 obj2=new AssetVer2();		

		obj2.AssetId="10";

		Console.WriteLine("obj2 AssetId: {0}",obj2.AssetId);
		

	}
}