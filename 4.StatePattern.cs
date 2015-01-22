//Simple Example State Pattern

using System;

namespace StatePattern
{
	class MainClass
	{

		public class Context
		{
			public StateBase State{ get; set;}

			public Context(StateBase s) //use an initial state to construct the Context instance
			{
				this.State = s;
			}

			public void Request()
			{
				State.Change (this);
			}

			public void Show()
			{
				State.ShowState ();
			}
		}

		public interface StateBase  //StateBase class define method shared by all concrete states
		{
			void Change(Context context); //must have a method to change state
			void ShowState(); // method act differently according to different states
		}

		public class StateA : StateBase //StateA inherit from StateBase and implement methods uniquely
		{
			void StateBase.Change(Context context)
			{
				context.State = new StateB (); // change to stateB if current state is A
				Console.WriteLine ("change state from A to B");
			}

			void StateBase.ShowState()
			{
				Console.WriteLine ("Now is State A");
			}
		}

		public class StateB :StateBase  //StateB inherit from StateBase and implement methods uniquely
		{
			void StateBase.Change(Context context)
			{
				context.State = new StateC (); //change to stateC if current state is B
				Console.WriteLine ("change state from B to C");
			}

			void StateBase.ShowState()
			{
				Console.WriteLine ("Now is State B");
			}
		}

		public class StateC : StateBase //StateC inherit from StateBase and implement methods uniquely
		{
			void StateBase.Change(Context context)
			{ 
				context.State = new StateA (); //change to stateA if current state is C
				Console.WriteLine ("change state from C to A");
			}

			void StateBase.ShowState()
			{
				Console.WriteLine ("Now is State C");
			}
		}

		public static void Main (string[] args)
		{
			Context c = new Context (new StateB ());
			for (int i = 0; i < 10; i++) {
				c.Show ();
				c.Request ();
			}
		}
	}
}
