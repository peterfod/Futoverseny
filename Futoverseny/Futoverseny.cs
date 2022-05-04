using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futoverseny
{
	public partial class frmMain : Form
	{
		public static List<Futok> lista = new List<Futok>();
		public static string fajlnev { get; set; }
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnKilepes_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBeolvas_Click(object sender, EventArgs e)
		{
			btnBeolvas.Enabled = false;
			mniBeolvas.Enabled = false;
			//var sr = new StreamReader("futok.txt", Encoding.Latin1);
			var sr = new StreamReader("futok.txt", Encoding.GetEncoding("iso-8859-1"));
			while (!sr.EndOfStream)
			{
				var sor = new Futok(sr.ReadLine());
				lista.Add(sor);
				lsbResztvevok.Items.Add(sor.Nev);
			}
			sr.Close();
		}

		private void lsbResztvevok_SelectedIndexChanged(object sender, EventArgs e)
		{
			txbRajtszam.Text = lista[lsbResztvevok.SelectedIndex].Rajtszam;
			txbOrszag.Text = lista[lsbResztvevok.SelectedIndex].Orszag;
			txbIdo.Text = lista[lsbResztvevok.SelectedIndex].Eredmeny;
			txbKor.Text = lista[lsbResztvevok.SelectedIndex].Kor.ToString();
		}

		private void mniEredmenylista_Click(object sender, EventArgs e)
		{
			this.Hide();
			//create an instance of frmEredmenylista:
			frmEredmenylista ar = new frmEredmenylista();
			ar.ShowDialog();
			ar.Dispose();
			this.Show();
		}
	}
}
