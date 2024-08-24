using System;

namespace Samples.Tutorial.TablaT
{
	class MainClass
	{
		public static int Main (string[] args)
		{
			Console.WriteLine ("+----------------------------+");
			Console.WriteLine(" Logical AND (&&)");
			Console.WriteLine(" F && F: " + (false && false));
			Console.WriteLine(" F && T: " + (false && true));
			Console.WriteLine(" T && F: " + (true && false));
			Console.WriteLine(" T && T: " + (true && true));
			Console.WriteLine("+------------------------------+");
			Console.WriteLine(" Logical OR (||)");
			Console.WriteLine(" F && F: " + (false || false));
			Console.WriteLine(" F && T: " + (false || true));
			Console.WriteLine(" T && F: " + (true || false));
			Console.WriteLine(" T && T: " + (true || true));
			Console.WriteLine("+------------------------------+");
			Console.WriteLine(" Boolean logical AND (&)");
			Console.WriteLine(" F & F: " + (0 & 0));
			Console.WriteLine(" F & T: " + (0 & 1));
			Console.WriteLine(" T & F: " + (1 & 0));
			Console.WriteLine(" T & T: " + (1 & 1));
			Console.WriteLine("+-------------------------------+");
			Console.WriteLine(" Boolean logical inclusive OR (|)");
			Console.WriteLine(" F | F: " + (0 | 0));
			Console.WriteLine(" F | T: " + (0 | 1));
			Console.WriteLine(" T | F: " + (1 | 0));
			Console.WriteLine(" T | T: " + (1 | 1));
			Console.WriteLine("+---------------------------------+");
			Console.WriteLine(" Boolean logical exclusive OR (^)");
			Console.WriteLine(" F ^ F: " + (0 ^ 0));
			Console.WriteLine(" F ^ T: " + (0 ^ 1));
			Console.WriteLine(" T ^ F: " + (1 ^ 0));
			Console.WriteLine(" T ^ T: " + (1 ^ 1));
			Console.WriteLine("+---------------------------------+");
			Console.WriteLine(" Logical NOT (!) ");
			Console.WriteLine(" !F: " + (!false));
			Console.WriteLine(" !T: " + (!true));
			Console.WriteLine("+---------------------------------+");
			return 0;

		}
	}
}
