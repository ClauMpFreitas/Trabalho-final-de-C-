using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrjAgendaContatos
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}
		
		void ContatosToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmContatos fc = new FrmContatos();
			fc.Show();
		}
		
		void CalculadoraToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process.Start("calc.exe");
		}
		
		void RelógioToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmRelogio fr = new FrmRelogio();
			fr.Show();
		}
		
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmSobre fs = new FrmSobre();
			fs.Show();
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			Process.Start("calc.exe");
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			FrmContatos fc = new FrmContatos();
			fc.Show();
		}
		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			FrmRelogio fr = new FrmRelogio();
			fr.Show();
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
