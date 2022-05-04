
namespace Futoverseny
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnBeolvas = new System.Windows.Forms.Button();
			this.btnKilepes = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txbRajtszam = new System.Windows.Forms.TextBox();
			this.txbOrszag = new System.Windows.Forms.TextBox();
			this.txbIdo = new System.Windows.Forms.TextBox();
			this.txbKor = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniBeolvas = new System.Windows.Forms.ToolStripMenuItem();
			this.mniKilepes = new System.Windows.Forms.ToolStripMenuItem();
			this.mniEredmenylista = new System.Windows.Forms.ToolStripMenuItem();
			this.lsbResztvevok = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBeolvas
			// 
			resources.ApplyResources(this.btnBeolvas, "btnBeolvas");
			this.btnBeolvas.Name = "btnBeolvas";
			this.btnBeolvas.UseVisualStyleBackColor = true;
			this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
			// 
			// btnKilepes
			// 
			resources.ApplyResources(this.btnKilepes, "btnKilepes");
			this.btnKilepes.Name = "btnKilepes";
			this.btnKilepes.UseVisualStyleBackColor = true;
			this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// txbRajtszam
			// 
			resources.ApplyResources(this.txbRajtszam, "txbRajtszam");
			this.txbRajtszam.Name = "txbRajtszam";
			this.txbRajtszam.ReadOnly = true;
			// 
			// txbOrszag
			// 
			resources.ApplyResources(this.txbOrszag, "txbOrszag");
			this.txbOrszag.Name = "txbOrszag";
			this.txbOrszag.ReadOnly = true;
			// 
			// txbIdo
			// 
			resources.ApplyResources(this.txbIdo, "txbIdo");
			this.txbIdo.Name = "txbIdo";
			this.txbIdo.ReadOnly = true;
			// 
			// txbKor
			// 
			resources.ApplyResources(this.txbKor, "txbKor");
			this.txbKor.Name = "txbKor";
			this.txbKor.ReadOnly = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.mniEredmenylista});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// fájlToolStripMenuItem
			// 
			this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBeolvas,
            this.mniKilepes});
			this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
			resources.ApplyResources(this.fájlToolStripMenuItem, "fájlToolStripMenuItem");
			// 
			// mniBeolvas
			// 
			this.mniBeolvas.Name = "mniBeolvas";
			resources.ApplyResources(this.mniBeolvas, "mniBeolvas");
			this.mniBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
			// 
			// mniKilepes
			// 
			this.mniKilepes.Name = "mniKilepes";
			resources.ApplyResources(this.mniKilepes, "mniKilepes");
			this.mniKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
			// 
			// mniEredmenylista
			// 
			this.mniEredmenylista.Name = "mniEredmenylista";
			resources.ApplyResources(this.mniEredmenylista, "mniEredmenylista");
			this.mniEredmenylista.Click += new System.EventHandler(this.mniEredmenylista_Click);
			// 
			// lsbResztvevok
			// 
			this.lsbResztvevok.FormattingEnabled = true;
			resources.ApplyResources(this.lsbResztvevok, "lsbResztvevok");
			this.lsbResztvevok.Name = "lsbResztvevok";
			this.lsbResztvevok.SelectedIndexChanged += new System.EventHandler(this.lsbResztvevok_SelectedIndexChanged);
			// 
			// frmMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lsbResztvevok);
			this.Controls.Add(this.txbKor);
			this.Controls.Add(this.txbIdo);
			this.Controls.Add(this.txbOrszag);
			this.Controls.Add(this.txbRajtszam);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKilepes);
			this.Controls.Add(this.btnBeolvas);
			this.Controls.Add(this.menuStrip1);
			this.Name = "frmMain";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBeolvas;
		private System.Windows.Forms.Button btnKilepes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txbRajtszam;
		private System.Windows.Forms.TextBox txbOrszag;
		private System.Windows.Forms.TextBox txbIdo;
		private System.Windows.Forms.TextBox txbKor;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mniBeolvas;
		private System.Windows.Forms.ToolStripMenuItem mniKilepes;
		private System.Windows.Forms.ToolStripMenuItem mniEredmenylista;
		private System.Windows.Forms.ListBox lsbResztvevok;
	}
}

