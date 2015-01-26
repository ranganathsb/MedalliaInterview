//simple example of a thread-safe singleton pattern

using System;

namespace SingletonPattern
{

	public sealed class Singleton
	{
		private static Singleton instance = null; //A static variable which holds a reference 
												//to the single created instance, if any
		private static readonly object PadLock = new object ();//A thread lock object

		private Singleton() //A single constructor, which is private and has no paramenter
		{

		}

		public static Singleton Instance  //A public property providing access to instance
		{
			get{
				lock (PadLock) { // The lock keyword marks a statement block as a critical section 
								//by obtaining the mutual-exclusion lock for a given object, 
								//executing a statement, and then releasing the lock.

					if (instance == null) // if instance is null, create a new Singleton instance
						instance = new Singleton ();
					return instance;
				}
			}
		}

	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
}
