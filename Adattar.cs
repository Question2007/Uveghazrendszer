using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Adattar
	{
		List<NovenyFaj> novenyek;
		public Adattar() 
		{ 
			this.novenyek = new List<NovenyFaj>();
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
	}
}
