/*
 * Created by SharpDevelop.
 * User: uJão
 * Date: 29/06/2021
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of FrmJanela02.
	/// </summary>
	public partial class FrmJanela02 : Form
	{
		public FrmJanela02()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja mesmo sair?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Close();			
		}
	}
}
