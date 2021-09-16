using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}
				
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja mesmo sair?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Close();
		}
		
		void Tela1ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FrmJanela f1 = new FrmJanela();
			f1.Show();			
		}
		
		void Tela2ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FrmJanela02 f2 = new FrmJanela02();
			f2.Show();			
		}
		
		void Tela3ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FrmJanela03 f3 = new FrmJanela03();
			f3.Show();	
		}
	}
}
