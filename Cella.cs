using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Cella
	{
		Pozicio pozicio;
		NovenyFaj novenyfaj;
		int egyedSzam;
		List<Szenzor> szenzorok;
		List<Riasztas> riasztasok;

		public Cella(int x, int y)
		{
			this.pozicio = new Pozicio(x, y);
			this.novenyfaj = null;
			this.egyedSzam = 0;
			this.szenzorok = new List<Szenzor>();
			this.riasztasok = new List<Riasztas>();
		}

		public int EgyedSzam { get => egyedSzam; set => egyedSzam = value; }
		internal Pozicio Pozicio { get => pozicio; set => pozicio = value; }
		internal NovenyFaj Novenyfaj { get => novenyfaj; set => novenyfaj = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }

		public bool UresE
		{
			get
			{
				return this.novenyfaj == null;
			}
		}
		public bool Telepit(NovenyFaj noveny, int mennyiseg)
		{
			bool sikeres = false;
			if (mennyiseg > 0 && UresE)
			{
				this.novenyfaj = noveny;
				this.egyedSzam = mennyiseg;
				Console.WriteLine($"{novenyfaj.Nev} telepítése sikeres");
				sikeres = true;
			}
			else if (mennyiseg > 0 && this.novenyfaj.Equals(noveny))
			{
				Noveles(mennyiseg);
			}

			return sikeres;
		}

		public void Noveles(int mennyiseg)
		{
			this.egyedSzam += mennyiseg;
		}

		public void Csokkentes(int mennyiseg)
		{
			this.egyedSzam -= mennyiseg;
			if (egyedSzam <= 0)
			{
				Urites();
			}
		}

		public void Urites()
		{
			this.novenyfaj = null;
			this.egyedSzam = 0;

		}

		public override string ToString()
		{
			if (this.UresE)
			{
				return $"| {"ures", 8} |";
			}
			return $"| {this.novenyfaj.Azonosito,3} {this.egyedSzam,2}db |";
		}
	}
}
