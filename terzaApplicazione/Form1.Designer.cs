
namespace terzaApplicazione
{
	partial class Form1
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
			this.lstIndirizzi = new System.Windows.Forms.ListBox();
			this.btnNuovo = new System.Windows.Forms.Button();
			this.btnCancella = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuApri = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSalva = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEsci = new System.Windows.Forms.ToolStripMenuItem();
			this.archiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNegozi = new System.Windows.Forms.ToolStripMenuItem();
			this.dlgApri = new System.Windows.Forms.OpenFileDialog();
			this.dlgSalva = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstIndirizzi
			// 
			this.lstIndirizzi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstIndirizzi.FormattingEnabled = true;
			this.lstIndirizzi.ItemHeight = 20;
			this.lstIndirizzi.Location = new System.Drawing.Point(12, 32);
			this.lstIndirizzi.Name = "lstIndirizzi";
			this.lstIndirizzi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstIndirizzi.Size = new System.Drawing.Size(390, 364);
			this.lstIndirizzi.TabIndex = 0;
			this.lstIndirizzi.SelectedIndexChanged += new System.EventHandler(this.lstIndirizzi_SelectedIndexChanged);
			this.lstIndirizzi.DoubleClick += new System.EventHandler(this.lstIndirizzi_DoubleClick);
			// 
			// btnNuovo
			// 
			this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuovo.Location = new System.Drawing.Point(307, 428);
			this.btnNuovo.Name = "btnNuovo";
			this.btnNuovo.Size = new System.Drawing.Size(94, 29);
			this.btnNuovo.TabIndex = 1;
			this.btnNuovo.Text = "nuovo";
			this.btnNuovo.UseVisualStyleBackColor = true;
			this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
			// 
			// btnCancella
			// 
			this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancella.Location = new System.Drawing.Point(13, 428);
			this.btnCancella.Name = "btnCancella";
			this.btnCancella.Size = new System.Drawing.Size(94, 29);
			this.btnCancella.TabIndex = 2;
			this.btnCancella.Text = "cancella";
			this.btnCancella.UseVisualStyleBackColor = true;
			this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.archiviToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(414, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuApri,
            this.mnuSalva,
            this.mnuEsci});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuApri
			// 
			this.mnuApri.Name = "mnuApri";
			this.mnuApri.Size = new System.Drawing.Size(224, 26);
			this.mnuApri.Text = "Apri";
			this.mnuApri.Click += new System.EventHandler(this.mnuApri_Click);
			// 
			// mnuSalva
			// 
			this.mnuSalva.Name = "mnuSalva";
			this.mnuSalva.Size = new System.Drawing.Size(224, 26);
			this.mnuSalva.Text = "Salva";
			this.mnuSalva.Click += new System.EventHandler(this.mnuSalva_Click);
			// 
			// mnuEsci
			// 
			this.mnuEsci.Name = "mnuEsci";
			this.mnuEsci.Size = new System.Drawing.Size(224, 26);
			this.mnuEsci.Text = "Esci";
			this.mnuEsci.Click += new System.EventHandler(this.mnuEsci_Click);
			// 
			// archiviToolStripMenuItem
			// 
			this.archiviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNegozi});
			this.archiviToolStripMenuItem.Name = "archiviToolStripMenuItem";
			this.archiviToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
			this.archiviToolStripMenuItem.Text = "Archivi";
			// 
			// mnuNegozi
			// 
			this.mnuNegozi.Name = "mnuNegozi";
			this.mnuNegozi.Size = new System.Drawing.Size(140, 26);
			this.mnuNegozi.Text = "Negozi";
			// 
			// dlgApri
			// 
			this.dlgApri.FileName = "openFileDialog1";
			this.dlgApri.Filter = "File JSON (.json)|*.json|Tutti i file|*.*";
			// 
			// dlgSalva
			// 
			this.dlgSalva.Filter = "File JSON (.json)|*.json|Tutti i file|*.*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 469);
			this.Controls.Add(this.btnCancella);
			this.Controls.Add(this.btnNuovo);
			this.Controls.Add(this.lstIndirizzi);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstIndirizzi;
		private System.Windows.Forms.Button btnNuovo;
		private System.Windows.Forms.Button btnCancella;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuApri;
		private System.Windows.Forms.ToolStripMenuItem mnuSalva;
		private System.Windows.Forms.ToolStripMenuItem mnuEsci;
		private System.Windows.Forms.ToolStripMenuItem archiviToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuNegozi;
		private System.Windows.Forms.OpenFileDialog dlgApri;
		private System.Windows.Forms.SaveFileDialog dlgSalva;
	}
}

