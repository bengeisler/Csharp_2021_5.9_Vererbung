using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_5._9_Vererbung
{
	// Abgeleitete Klasse PKW erbt von Basisklasse Fahrzeug
	// Dies wird durch : angegeben
	class PKW : Fahrzeug
	{
		// Eigenschaft
		private int insassen;

		// Methode
		public void Einsteigen(int anzahl) => insassen += anzahl;

		// ToString() überschreiben
		public override string ToString()
		{
			// base: Zugriff auf die Basisklasse
			// base.ToString() : ToString()-Methode der Basisklasse ausführen
			return "Insassen: " + insassen + "\n" + base.ToString();
		}
	}
}
