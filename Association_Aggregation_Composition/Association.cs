

using System;
using System.Collections.Generic;

public class Manager
{

	//A Aggregation
	//Only one owner

	public List<Worker> Workers=new List<Worker>();

	public void LogOn(SwipeCard o)
	{
			o.Swipe(this);
	}

	public double Salary;
	public void HowIsTheManager(bool Good)
	{
		if(Good)
		{
			
		}
	}

	public string GetManagerName()
	{
			return "Venkatesh";
	}

	//Composition Relationship
	//

}

public class Project
{
	public boolean isSuccess=false;
	public double Salary;
}

public class SwipeCard
{
	public void Swipe(Manager o)
	{

	}
	public string MakeofSwipeCard()
	{
		return "M001";
	}
}

public class Worker
{
	public string WorkerName{get;set;}
}
class Program
{
	public static void Main()
	{
		SwipeCard oSwipe=new SwipeCard();
		Manager oMgr=new Manager();

		//Association
		//oMgr.LogOn(oSwipe)
		


	}
}