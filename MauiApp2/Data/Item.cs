using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
	public class Item
	{
		public TypVek Vek = TypVek.Dospely;
		public TypKontainera Kontainer = TypKontainera.Bez;
		public bool MaVratKus = false;
		public bool MaAlkohol = false;
        public DateTime CasCelkovy = new DateTime(2000, 1, 1, 0, 0, 0); //Casomiera MAX jeden den, inak reset
		public DateTime CasVRade = new DateTime(2000, 1, 1, 0, 0, 0);
		public DateTime CasZaPokladnou = new DateTime(2000, 1, 1, 0, 0, 0);
		public DateTime CasZaVratnouStanicou = new DateTime(2000, 1, 1, 0, 0, 0);

		public string FarbaVlasov = "#FFFFFF";
		public string FarbaOblecenia = "#FFFFFF";
		public bool[] CasManager = new bool[4];			//tolko kolko mame DateTime casovacov, treba si pamatat poradie (aktualne tak ako su za sebou napisane)
		//pohlavie?

		public string getCsvZaznam() {		//vrati zaznam oddeleny ';' + enter
			return CasCelkovy.ToString("mm:ss") + ";" + CasVRade.ToString("mm:ss") + ";" + CasZaPokladnou.ToString("mm:ss") + ";" + CasZaVratnouStanicou.ToString("mm:ss") + ";" + Vek + ";"
				+ Kontainer + ";" + MaVratKus + ";" + MaAlkohol + "\n";
		}
	}
}
