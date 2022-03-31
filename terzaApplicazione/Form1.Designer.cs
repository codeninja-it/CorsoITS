
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
			this.SuspendLayout();
			// 
			// lstIndirizzi
			// 
			this.lstIndirizzi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstIndirizzi.FormattingEnabled = true;
			this.lstIndirizzi.ItemHeight = 20;
			this.lstIndirizzi.Location = new System.Drawing.Point(12, 12);
			this.lstIndirizzi.Name = "lstIndirizzi";
			this.lstIndirizzi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstIndirizzi.Size = new System.Drawing.Size(390, 384);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 469);
			this.Controls.Add(this.btnCancella);
			this.Controls.Add(this.btnNuovo);
			this.Controls.Add(this.lstIndirizzi);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstIndirizzi;
		private System.Windows.Forms.Button btnNuovo;
		private System.Windows.Forms.Button btnCancella;
	}
}

