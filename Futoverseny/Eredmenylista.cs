using System;
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
	public partial class frmEredmenylista : Form
	{
		public frmEredmenylista()
		{
			InitializeComponent();
		}

		private void frmEredmenylista_Load(object sender, EventArgs e)
		{
			foreach (var sor in frmMain.lista.OrderByDescending(f => f.Eredmeny))
			{
				rtbEredmeny.Text += sor.Nev + ": "+ sor.Eredmeny + "\n";
			}
		}

		private void mniMentes_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				rtbEredmeny.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
			}
		}

		private void btnBezar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
