//Simple Example for Adapter pattern

using System;

namespace AdapterPattern
{
	public interface Target //Target interface that is compitable with client
	{
		void MethodA();
	}

	public class Client  //client class has Target instance, can only make call through Target interface
	{
		private Target target;
		public Client(Target t)
		{
			this.target = t;
		}

		public void MakeRequest()
		{
			target.MethodA ();
		}
	}

	public class Adaptee  //Adaptee has the MethodB that client wants to call
	{
		public void MethodB()
		{
			Console.WriteLine("Method B is called!!");
		}
	}


	public class Adapter: Adaptee, Target //Adapter inherit from both Adaptee and Target
	{	
		void Target.MethodA() //implement MethodA of Target interface
		{
			this.MethodB ();  //using MethodB from parent clccass
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Target t = new Adapter (); //instiante Target interface with Adapter
			Client c = new Client (t); //put the instance of Target interface into client
			c.MakeRequest ();          //now client can use method B from Adaptee through Adapter
			Adapter a = new Adapter (); // we can also directly put the instance of Adapter into client
			Client cc = new Client (a);
			cc.MakeRequest ();
		}
	}
}
