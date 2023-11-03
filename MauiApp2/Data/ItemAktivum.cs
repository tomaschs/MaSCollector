using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
	public class ItemAktivum : IItems
	{
		public bool Aktivum = true;	// false - bezobsluzna p.  / true - normalna p.  // false - kosik / true - vozik // false/true - je jedno pre flaskomaty
		public (DateTime, int) PocetAktivVCase = (DateTime.Now, 0);       //Tuple ({datum od kedy su pokladne aktivne}, {kolko ich je aktivnych}) // ({datum kedy su dostupne kontainre}, {kolko ich je aktivnych}) // ({datum kedy su aktivne flaskomaty}, {kolko ich je aktivnych})

		public string GetCsvZaznam() {		//pre flaskomaty treba ignorovat Aktivum
			return Aktivum + ";" + PocetAktivVCase.Item1.ToString("dd.MM.yyyy HH:mm:ss") + ";" + PocetAktivVCase.Item2 + "\n";
		}
	}
}
