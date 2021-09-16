/*
 * Created by SharpDevelop.
 * User: uJão
 * Date: 29/06/2021
 * Time: 11:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tela1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tela2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tela3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.sairToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(734, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tela1ToolStripMenuItem1,
									this.tela2ToolStripMenuItem1,
									this.tela3ToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// tela1ToolStripMenuItem1
			// 
			this.tela1ToolStripMenuItem1.Name = "tela1ToolStripMenuItem1";
			this.tela1ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.tela1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.tela1ToolStripMenuItem1.Text = "Tela 1";
			this.tela1ToolStripMenuItem1.Click += new System.EventHandler(this.Tela1ToolStripMenuItem1Click);
			// 
			// tela2ToolStripMenuItem1
			// 
			this.tela2ToolStripMenuItem1.Name = "tela2ToolStripMenuItem1";
			this.tela2ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.tela2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.tela2ToolStripMenuItem1.Text = "Tela 2";
			this.tela2ToolStripMenuItem1.Click += new System.EventHandler(this.Tela2ToolStripMenuItem1Click);
			// 
			// tela3ToolStripMenuItem1
			// 
			this.tela3ToolStripMenuItem1.Name = "tela3ToolStripMenuItem1";
			this.tela3ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.tela3ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.tela3ToolStripMenuItem1.Text = "Tela 3";
			this.tela3ToolStripMenuItem1.Click += new System.EventHandler(this.Tela3ToolStripMenuItem1Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(172, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 129);
			this.label1.TabIndex = 1;
			this.label1.Text = "Olá Mundo!!!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(734, 362);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu Principal de Aplicação";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem tela3ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tela2ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tela1ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
