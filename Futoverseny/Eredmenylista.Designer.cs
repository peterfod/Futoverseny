
namespace Futoverseny
{
	partial class frmEredmenylista
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.rtbEredmeny = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mniMentes = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBezar = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbEredmeny
			// 
			this.rtbEredmeny.ContextMenuStrip = this.contextMenuStrip1;
			this.rtbEredmeny.Location = new System.Drawing.Point(48, 84);
			this.rtbEredmeny.Name = "rtbEredmeny";
			this.rtbEredmeny.Size = new System.Drawing.Size(362, 282);
			this.rtbEredmeny.TabIndex = 0;
			this.rtbEredmeny.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMentes});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
			// 
			// mniMentes
			// 
			this.mniMentes.Name = "mniMentes";
			this.mniMentes.Size = new System.Drawing.Size(155, 22);
			this.mniMentes.Text = "Lista mentése...";
			this.mniMentes.Click += new System.EventHandler(this.mniMentes_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.SlateBlue;
			this.label1.Location = new System.Drawing.Point(115, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Versenyeredmények";
			// 
			// btnBezar
			// 
			this.btnBezar.Location = new System.Drawing.Point(174, 390);
			this.btnBezar.Name = "btnBezar";
			this.btnBezar.Size = new System.Drawing.Size(139, 35);
			this.btnBezar.TabIndex = 2;
			this.btnBezar.Text = "Bezár";
			this.btnBezar.UseVisualStyleBackColor = true;
			this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "Eredmenyek";
			this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			// 
			// frmEredmenylista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(459, 450);
			this.Controls.Add(this.btnBezar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rtbEredmeny);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "frmEredmenylista";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Eredménylista";
			this.Load += new System.EventHandler(this.frmEredmenylista_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbEredmeny;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBezar;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mniMentes;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}