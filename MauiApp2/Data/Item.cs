using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
	public class Item
	{
		public TypVek Vek = TypVek.Dospely;
		public TypKontainera Kontainer = TypKontainera.Bez;
		public bool MaVratKus = false;
		public bool Pohlavie = false;       //false - muz / true - zena
		public bool Pokladna = false;		//false - samoobsluha / true - pokladna
        public DateTime CasCelkovy = new DateTime(2000, 1, 1, 0, 0, 0); //Casomiera MAX jeden den, inak reset
		public DateTime CasVozik = new DateTime(2000, 1, 1, 0, 0, 0);
		public DateTime CasVRade = new DateTime(2000, 1, 1, 0, 0, 0);
		public DateTime CasZaPokladnou = new DateTime(2000, 1, 1, 0, 0, 0);
		public DateTime CasZaVratnouStanicou = new DateTime(2000, 1, 1, 0, 0, 0);
		public List<string> MoznostiNakupu = new List<string>();     //{ "Pecivo", "Voda", "Alkohol", "Drogeria", "Maso" }


		public string FarbaVlasov = "#FFFFFF";
		public string FarbaOblecenia = "#FFFFFF";
		public bool[] CasManager = new bool[5];			//tolko kolko mame DateTime casovacov, treba si pamatat poradie (aktualne tak ako su za sebou napisane)
		//pohlavie?

		public string getCsvZaznam() {      //vrati zaznam oddeleny ';' + enter

			string moznosti = JsonSerializer.Serialize(MoznostiNakupu);     //serializnem si to, snad to bude fungovat odserializovat v jave. Zevraj import com.google.gson.Gson;  YourClass[] yourArray = new Gson().fromJson(jsonString, YourClass[].class);

			return CasCelkovy.ToString("mm:ss") + ";" + CasVozik.ToString("mm:ss") + ";" + CasVRade.ToString("mm:ss") + ";"
				+ CasZaPokladnou.ToString("mm:ss") + ";" + CasZaVratnouStanicou.ToString("mm:ss") + ";" + Pohlavie + ";" + Vek + ";"
				+ Kontainer + ";" + MaVratKus + ";" + Pokladna + ";" + moznosti + "\n";
		}
	}
}
