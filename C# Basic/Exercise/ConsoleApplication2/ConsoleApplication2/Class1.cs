using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication2
{

	class PolymorphDemo
	{
		public static void Main()
		{
			Child ObjChild = new Child();
			Console.WriteLine("The output is " + ObjChild.MethodA());
			Console.ReadLine();
		}

	}


	class Parent
	{
		event Display a;
		public int MethodA()
		{
			return (MethodB() * MethodC());
		}
		public virtual int MethodB()
		{
			return (10);
		}
		public int MethodC()
		{
			return (20);
		}
	}

	class Child : Parent
	{
		public override int MethodB()
		{

			try
			{
			}
			catch(Exception e)
			{}
			catch{Exception b}

			return 1;
		}

		

		

	}

}

