using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MauiApp2.Data
{
	public class Zberac
	{
		public static List<Item> ZoznamZaznamov = new List<Item>();				//ludia
		public static List<ItemAktivum> ZoznamPredajna = new List<ItemAktivum>();		//predajne
		public static List<ItemAktivum> ZoznamKontainer = new List<ItemAktivum>();		//kontainre
		public static List<ItemAktivum> ZoznamFlaskomat = new List<ItemAktivum>();		//flaskomat/y


		public static string FolderPath = "Vyber priecinok...";				//priecinok, kde sa ulozia csv

		private static System.Timers.Timer timer;		//casovac
		private static ElapsedEventHandler[] listofEvents = new ElapsedEventHandler[5];		//list dostupnxch miest pre registrciu metod, ktore sa maju opakovat po sekunde napr


		public static void ReIniTimer(System.Timers.ElapsedEventHandler iniMethod, int place) //spusti casovac ak este nebol 
		{
			if (timer == null)      //ak neni nastaveny tak sa nastavi
			{
				timer = new System.Timers.Timer(1000); // 1-second interval
				timer.Start();
			}

			if (place >= listofEvents.Length) {				
				throw new ArgumentException("Zly casovac, mimo rozsahu pola");
			}

			if (listofEvents[place] != null)    //nastavi podla indexu casovac (kazdy tab v nave ma svoj vlastny a ked sa preklikava tak sa mazu)
			{
				timer.Elapsed -= listofEvents[place];
			}
			timer.Elapsed += iniMethod;
			listofEvents[place] = iniMethod;
		}
	}
}

