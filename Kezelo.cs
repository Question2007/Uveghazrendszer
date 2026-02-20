using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Kezelo
	{
		string nev;
		string azonosito;
		Szerepkor szerepkor;

		public Kezelo(string nev, string azonosito, Szerepkor szerepkor)
		{
			this.nev = nev;
			this.azonosito = azonosito;
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		internal Szerepkor Szerepkor { get => szerepkor; set => szerepkor = value; }

		public override string ToString()
		{
			return $"{this.nev} ({this.azonosito}) {this.szerepkor}";
		}
	}
}
