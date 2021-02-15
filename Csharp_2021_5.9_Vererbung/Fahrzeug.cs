using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_5._9_Vererbung
{
	class Fahrzeug
	{
		// Eigenschaft
		private int geschwindigkeit;

		// Methode
		//public void Beschleunigen(int wert)
		//{
		//	geschwindigkeit += wert;
		//}
		public void Beschleunigen(int wert) 
			=> geschwindigkeit += wert;

		// Methode ToString() der Basisklasse object überschreiben
		//public override string ToString()
		//{
		//	return "Geschwindigkeit: " + geschwindigkeit + "\n";
		//}

		public override string ToString() 
			=> "Geschwindigkeit: " + geschwindigkeit + "\n";
	}
}
