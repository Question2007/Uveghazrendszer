using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class NovenyFaj
	{
		string nev;
		int nedvessegtartalom; // 100 az ideális
		int egeszsegSzint; //100 a max
		int optimalisSuruseg;

		public NovenyFaj(string nev, int optimalisSuruseg)
		{
			this.nev = nev;
			this.optimalisSuruseg = optimalisSuruseg;
			this.nedvessegtartalom = 100;
			this.egeszsegSzint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Nedvessegtartalom { get => nedvessegtartalom; set => nedvessegtartalom = value; }
		public int EgeszsegSzint { get => egeszsegSzint; set => egeszsegSzint = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

		public string Azonosito
		{
			get
			{
				return this.nev.Substring(0, 3);
			}
		}

		public override string ToString()
		{
			return $"{this.nev} nedvesség: {this.nedvessegtartalom} egészség: {this.egeszsegSzint} ideális egyedszám: {this.optimalisSuruseg}";
		}
	}
}
