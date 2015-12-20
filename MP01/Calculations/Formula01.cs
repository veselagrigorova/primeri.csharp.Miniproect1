using System;

namespace Calculations
{
	public class Formula01
	{
		public Formula01 () //формула за обикновена строителна яма
	
		{
		}

		// парсване
		public void calc (string _Userinnput)
		{
			try{
				string [] param = _Userinnput.Split (' ');
				if (param.Length > 1 && _Userinnput.Contains ("-п"));
				{
					//помощ за командата
				}
				if (param.Length > 1 && !_Userinnput.Contains ("-п"));
				{
					//Изчисления
					double _result = 0;
					if (runCalculations (param, out _result))
					{
						Console.Write("Обемът на строителната яма е: ");
						Console.WriteLine(_result.ToString ("N2" ));
					}else{
						Console.WriteLine ("Има грешно въведени параметри. Можете да проверите синтаксиса с параметъра '_п '");
					}

				}
			}catch {
			}
		
		}

		//изчисление и изписване
						private bool runCalculations (string[] _param, out double _result ) 

		{
			try{
				//_param[0] == ime na comanda
				double _a1=0, _b1=0, _a2=0, _b2=0, _h=0;

				Double.TryParse ( _param[1], out _a1);
				Double.TryParse ( _param[2], out _b1);
				Double.TryParse ( _param[3], out _a2);
				Double.TryParse ( _param[4], out _b2);
				Double.TryParse ( _param[5], out _h);

				Double F1 = _a1*_b1, F2=_a2*_b2;

				_result = _h *(F1 +F2) / 2;

				return true;

		} catch {
			

		}
			_result = 0;
			return false;

		//помощ за командата
	}
  }
}


