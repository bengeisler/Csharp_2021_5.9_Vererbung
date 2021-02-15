using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_5._9_Vererbung
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Fahrzeug meinFahrzeug = new Fahrzeug();
			PKW meinPKW = new PKW();

			// Ausgabe nach dem Erstellen
			Console.WriteLine("Objekte wurden erstellt");
			Console.WriteLine("Fahrzeug: " + meinFahrzeug);
			Console.WriteLine("PKW: " + meinPKW);

			// Fahrzeuge beschleunigen
			Console.WriteLine("Beschleunigen");
			meinFahrzeug.Beschleunigen(10);
			meinPKW.Beschleunigen(20);	// Methode der Basisklasse wird aufgerufen
			Console.WriteLine("Fahrzeug: " + meinFahrzeug);
			Console.WriteLine("PKW: " + meinPKW);

			// Einsteigen
			Console.WriteLine("Einsteigen");
			// meinFahrzeug.Einsteigen(2); => Funktioniert nicht! Basisklasse kennt 
			// die Methoden der spezialisierten Klasse nicht
			meinPKW.Einsteigen(2);
			Console.WriteLine("Fahrzeug: " + meinFahrzeug);
			Console.WriteLine("PKW: " + meinPKW);
		}
	}
}
