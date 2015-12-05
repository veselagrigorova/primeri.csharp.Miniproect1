using System;

namespace CALLCULATOR
{
	class MainClass
	{
		//Дефиниране на библиотеки

		public Userinnput.UInnput uinput = new	Userinnput.UInnput ();


		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			MainClass _program = new MainClass ();

			_program.uinput.justTesting ();
		}
	}
}
