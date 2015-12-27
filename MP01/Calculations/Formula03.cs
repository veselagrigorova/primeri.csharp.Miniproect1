﻿using System;

namespace Calculations
{
	public class Formula03
	{
		private Colours.ForCLI _cl = new Colours.ForCLI ();

		public Formula03 ()


		{
		}

		public void calc (string _input)
		{

			try{

				string[] param = _input.Split(' ');

				if( param.Length > 1 && _input.ToLower().Contains("-п"))

				{
					help();
				}

				if( param.Length == 4 )
				{
					double result = 0;

					if (runCalculate (param, out result ))

					{
						_cl.Default (); Console.Write("Обемът на изпъкналия ъгъл е ");
						_cl.Result ();  Console.Write(result.ToString("N2"));
						_cl.Default (); Console.WriteLine (" m3\n");

					}else{
						_cl.Default (); Console.Write("Има грешно въведени параметри. С параметъра '-п'можете\n да видите синтаксиса на командата.\n");


					}

				}

			}catch{

			}

		}
		private bool runCalculate (string[] _param, out double _result)
		{
			try{
				double a =0; Double.TryParse (_param[1], out a);
				double b =0; Double.TryParse (_param[2], out b);
				double h =0; Double.TryParse (_param[3], out h);

				_result = 2 * a * b * h / 3;


				return true;


			}catch{
			}

			_result = 0;
			return false;
		}

		private void help ()
		{
			_cl.Result (); Console.Write ("[иъгъл]");

			_cl.Default (); Console.WriteLine (" - изпъкнъл ъгъл");

			_cl.Command (); Console.Write (" параметри - ");
			_cl.Default (); Console.WriteLine ("a, b и h ");

			_cl.Command (); Console.Write (" a и b ");
			_cl.Default ();Console.WriteLine ("- ширина и дължина;");

			_cl.Command (); Console.Write (" h ");
			_cl.Default ();Console.WriteLine ("- височина\n\n");


		}


	}
}

