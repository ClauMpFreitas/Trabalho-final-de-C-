using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrjAgendaContatos
{
	public partial class FrmRelogio : Form
	{
		public FrmRelogio()
		{
			InitializeComponent();
		}
		
		void TmrRelogioTick(object sender, EventArgs e)
		{
			LblHora.Text = DateTime.Now.ToLongTimeString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
