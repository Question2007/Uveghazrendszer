using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Adattar
	{
		List<Kezelo> kezelok;
		List<NovenyFaj> novenyek;
		UveghazRacs uveghaz;

		internal UveghazRacs Uveghaz { get => uveghaz; set => uveghaz = value; }

		public Adattar() 
		{ 
			this.kezelok = new List<Kezelo>() { new Kezelo("Gibsz Jakab", "GJ", Szerepkor.KERTESZ), 
												new Kezelo("Aranka néni", "Ari", Szerepkor.ADMIN) };
			this.novenyek = new List<NovenyFaj>();
			this.uveghaz = new UveghazRacs(4);
			uveghaz.Parcellazas();

		}

		public void UjNoveny(NovenyFaj noveny)
		{
			novenyek.Add(noveny);
		}

		public void NovenyekListazasa()
		{
			foreach (var item in novenyek)
			{
				Console.WriteLine(item);
			}
		}
		public void Ultetes()
		{
			uveghaz.Ultetes(novenyek);
		}
	}
}
