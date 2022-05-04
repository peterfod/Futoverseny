using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futoverseny
{
	public class Futok
	{
		public string Rajtszam { get; set; }
		public string Nev { get; set; }
		public string Szulido { get; set; }
		public string Orszag { get; set; }
		public string Eredmeny { get; set; }
		public int Ev { get; set; }
		public int Honap { get; set; }
		public int Nap { get; set; }
		public int Kor { get; set; }

		public Futok(string sor)
		{
			string[] d = sor.Split(';');
			Rajtszam = d[0];
			Nev = d[1];
			Szulido = d[2];
			Orszag = d[3];
			Eredmeny = d[4];
			string[] datumdb = Szulido.Split('.');
			Ev = Convert.ToInt32(datumdb[0]);
			Honap = Convert.ToInt32(datumdb[1]);
			Nap = Convert.ToInt32(datumdb[1]);
			Kor = ((int)DateTime.Now.Year) - Ev;
		}
	}
}
