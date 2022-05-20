namespace Kaffee
{
	public class Kaffeemaschine
	{
		public double wasser { get; set; }

		private static double maxWasser = 2.5;
		public double bohnen { get; set; }

		private static double maxBohnen = 2.5;
		public double gesamtMengeKaffeProduziert { get; private set; }

		public Kaffeemaschine()
		{
			wasser = 0;
			bohnen = 0;
			gesamtMengeKaffeProduziert = 0;
		}

		public double wasserAuffuellen(double menge)
		{
			if (menge <= 0) return 0;

			if (menge + wasser <= maxWasser)
			{ 
				wasser += menge; 
				return menge; 
			}

			double echtemenge = maxWasser - wasser;
			wasser = maxWasser;
			return echtemenge;
		}

		public double bohnenAuffuellen(double menge)
		{
			if (menge <= 0) return 0;

			if (menge + bohnen <= maxBohnen)
			{ 
				bohnen += menge; 
				return menge; 
			}

			double echtemenge = maxBohnen - bohnen;
			bohnen = maxBohnen;
			return echtemenge;
		}

		public bool macheKaffee(double menge, double verhaeltnisWasserBohnen)
		{
			double anteilbohnen = menge / (verhaeltnisWasserBohnen + 1);
			double anteilwasser = menge - anteilbohnen;

			if (menge <= 0 || verhaeltnisWasserBohnen <= 0) return false;
			if (anteilbohnen > bohnen || anteilwasser > wasser) return false;

			bohnen -= anteilbohnen;
			wasser -= anteilwasser;

			gesamtMengeKaffeProduziert += menge;
			return true;
		}
	}
}